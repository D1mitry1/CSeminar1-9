// Задача 66.
// Задайте значения M и N. Напишите программу,
// которая найдет сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30



int m = InputNumbers("Enter M: ");
int n = InputNumbers("Enter N: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Sum of elements = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
