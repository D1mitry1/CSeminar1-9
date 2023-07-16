// Напишите программу, которая выводит
// случайное трехзначное число и 
// удаляет вторую цифру этого числа
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"A random three-digit number -> {number}");
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int resultDigit = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"A random three-digit number{number} is {resultDigit}");

int result = RemoveSecondDigit(number);
Console.WriteLine($"A random three-digit number{number} is {result}");


int RemoveSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;
    int resultDigit = firstDigit * 10 + thirdDigit;
    return resultDigit;
}
