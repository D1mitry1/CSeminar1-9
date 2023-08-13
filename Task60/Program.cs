// Задача 60.
// Сформируйте трехмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет
// построчно выводить массив, добавляя индексы
// каждого элемента.
// Массив размером 2х2х2
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)


int[,,] CreateMatrixInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth]; // rows = 2, colums = 2, depth = 2
    int count = 10;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] += count;
                count += 1;
            }
        }
    }
    return matrix;
}

void PrintIndex(int[,,] ind)
{
    for (int i = 0; i < ind.GetLength(0); i++)
    {
        for (int j = 0; j < ind.GetLength(1); j++)
        {
            // Console.WriteLine();
            for (int k = 0; k < ind.GetLength(2); k++)
            {
                Console.Write($"{ind[i, j, k]}({i},{j},{k})  ");
            }
        }
    }
}

int[,,] array3d = CreateMatrixInt(2, 2, 2, 10, 99);
PrintIndex(array3d);
