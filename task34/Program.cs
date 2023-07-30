// Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2



// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] arr = new int[size];

//     Random rnd = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(min, max + 1);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }

// int CountEvenNumbers(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= 100 && arr[i] <= 999)
//             count++;
//     }
//     return count;
// }

// int[] array = CreateArrayRndInt(5, 100, 999);
// PrintArray(array);

// Console.WriteLine();
// int countEvenNumbers = CountEvenNumbers(array);
// Console.WriteLine($"Количество четных чисел в массиве: {countEvenNumbers}");



// Другой метод

void PrintData(string res)
{
    Console.WriteLine(res);
}

int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}


int CountNumbers(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (Test(arr[i]))
        {
            res++;
        }
    }
    return res;
}

bool Test(int n)
{
    return (n % 2 == 0);
}


int[] testArr = Gen1DArray(5, 100, 999);

Print1DArr(testArr);

int count = CountNumbers(testArr);

PrintData("Количество четных чисел в массиве: " + count);







