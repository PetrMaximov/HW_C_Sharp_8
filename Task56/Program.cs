// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
    
int[,] RandomMatrix = new int [m,n];
for (int i = 0; i < RandomMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < RandomMatrix.GetLength(1); j++)
        {
          RandomMatrix[i,j] = new Random().Next(minLimitRandom, maxLimitRandom);
        }
    }
return RandomMatrix;
}

void PrintMatrix(int[, ] matrix) {
    
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          Console.Write("{0}\t", matrix[i,j]);
        }
    Console.WriteLine();
    }
  }

int MinSumSrting(int[, ] matrix) {
    
int[] Sum = new int [matrix.GetLength(0)];
int N = 0; 

for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          Sum[i] = Sum[i] + matrix[i,j];
        }
        //Console.WriteLine(Sum[i]);
    }
int Min = Sum[0];
for (int i = 1; i < Sum.Length; i++)
    {
        if (Min > Sum[i]) 
        {
            Min = Sum[i];
            N = i;
        }     
    }

return N + 1;
}


int[,] res = CreateRandomMatrix (3, 2, 0, 11);
PrintMatrix(res);
Console.WriteLine();
int Nres = MinSumSrting(res);
Console.WriteLine("Номер строки с наименьшей суммой элементов: " + Nres + " строка");
