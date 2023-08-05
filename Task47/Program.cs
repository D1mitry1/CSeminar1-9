// Задача 47.
// Задайте двумерный массив размером m х n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.

//       0       1       2       3

// 0   0,5     7,0    -2,0    -0,2
// 1   1,0    -3,3     8,0    -9,9
// 2   8,0     7,8    -7,1     9,0

// int rows = ReadInt("Enter the number of rows: ");
// int colums = ReadInt("Enter the number of colums: ");
// double[,] numbers = new double[rows, colums];
// FillArray2D(numbers);
// PrintArray2D(numbers);

int rows = 3;
int colums = 4;
double[,] numbers = new double[rows, colums];
FillArray2D(numbers);
PrintArray2D(numbers);

void FillArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100) / 10.0;
        }
    }
}

void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine('|');
    }
}

// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
