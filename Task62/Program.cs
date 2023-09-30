// Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 5;
int m = 5;

int[,] Matrix = new int [n,m];

for (int i = 0; i < m; i++)
{
    Matrix[0,i] = Matrix[0,i] + i + 1;
}

for (int i = 1; i< n; i++)
{
    Matrix[i,m-1] = Matrix[0, m-1] + i;
}

for (int i = m-2; i > -1; i--)
{
    Matrix[n-1,i] = Matrix[n-1, m-1] + (m-1) - i;
}

for (int i = n-2; i > 0; i--)
{
    Matrix[i,0] = Matrix[n-1, 0] + (n-1) - i;
}

for (int i = 1; i < m-1; i++)
{
    Matrix[1,i] = Matrix[1,0] + i;
}

for (int i = 2; i< n-1; i++)
{
    Matrix[i,m-2] = Matrix[1, m-2] + i-1;
}

for (int i = m-3; i > 0; i--)
{
    Matrix[n-2,i] = Matrix[n-2, m-2] + (m-2) - i;
}

for (int i = n-3; i > 1; i--)
{
    Matrix[i,1] = Matrix[n-2, 1] + (n-2) - i;
}

for (int i = 2; i < m-2; i++)
{
    Matrix[2,i] = Matrix[2,1] + i-1;
}


for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
          Console.Write("{0}\t", Matrix[i,j]);
        }
    Console.WriteLine();
    }

 Console.WriteLine();
 Console.WriteLine("Прошу прощения, должен сдать это дз, над рекурсией подумаю");   