// Напишите программу, которая 
// принимает на вход число и 
// выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Enter number: ");
int number = int.Parse(Console.ReadLine());
if (number < 0) number = -number;

int count = GetCountDigits(number);
Console.Write($"Number of digits in a number {number} = {count}");

int GetCountDigits(int num)
{
    if (num == 0) return 1;

    int counter = 0;
    while (num > 0)
    {
        num /= 10; // num = num / 10
        counter++; // counter = counter + 1;
    }
    return counter;
}
