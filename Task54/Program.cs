// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
    
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

int[, ] SortMatrixStringDecreas(int[, ] SortMatrix) {

    for (int i = 0; i < SortMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < SortMatrix.GetLength(1) - 1; j++)
                {
                    for (int j1 = j + 1; j1 < SortMatrix.GetLength(1); j1++)
                        {
                            if (SortMatrix[i,j] < SortMatrix[i,j1])
                            {
                                int temp = SortMatrix[i,j];
                                SortMatrix[i,j] = SortMatrix[i,j1];
                                SortMatrix[i,j1] = temp;
                            }
                        }
                }
        }
    return SortMatrix;
}





int[,] res = CreateRandomMatrix (4, 4, 0, 30);
PrintMatrix(res);
Console.WriteLine();
int[,] res1 = SortMatrixStringDecreas(res);
PrintMatrix(res1);