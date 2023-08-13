// Задача 58. 
// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны две матрицы:

// 2  4 | 3  4
// 3  2 | 3  3

// Результирующая матрица будет:
// 18 20
// 15 18


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine("|");
    }
}

void FillMatrixRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] matrix = new int[rows, columns];
int[,] secondMatrix = new int[rows, columns];
int[,] resultMatrix = new int[rows, columns];

FillMatrixRandom(matrix);
PrintMatrix(matrix);

Console.WriteLine();

FillMatrixRandom(secondMatrix);
PrintMatrix(secondMatrix);

Console.WriteLine();

if (matrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine("Нельзя перемножить матрицы,");
    Console.Write("количество строк не соответствует количеству столбцов ");
    return;
}
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
        }
    }
}

PrintMatrix(resultMatrix);
