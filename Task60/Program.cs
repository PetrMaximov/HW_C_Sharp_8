// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int n = 2; //страницы
int m = 2; //строки 
int l = 2; //столбцы
int minLimitRandom = 10;
int maxLimitRandom = 100;




int[,,] Random3DMatrix = new int [m,n,l];
for (int i = 0; i < Random3DMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < Random3DMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < Random3DMatrix.GetLength(2); k++)
            {
                link1:
                int RandomNum = new Random().Next(minLimitRandom, maxLimitRandom);
                bool b = true;


                for (int i1 = 0; i1 < Random3DMatrix.GetLength(0); i1++)
                {
                    for (int j1 = 0; j1 < Random3DMatrix.GetLength(1); j1++)
                    {
                        for (int k1 = 0; k1 < Random3DMatrix.GetLength(2); k1++)
                        {
                            if (RandomNum == Random3DMatrix[i1,j1,k1])
                            {
                                b = false;
                                break;
                            }
                        }
                    if (b == false) break; 
                    }
                if (b == false) break; 
                }
                if (b) Random3DMatrix[i,j,k] = RandomNum; 
                else goto link1;
                
            }
    }
}
  
for (int i = 0; i < Random3DMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < Random3DMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < Random3DMatrix.GetLength(2); k++)
            {
                Console.Write("{0}\t", Random3DMatrix[i,j,k] + $"({i},{j},{k})");
            }   
            Console.WriteLine(); 
        }
        
    }
