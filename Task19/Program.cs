// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int num, r, sum = 0, t;
Console.Write("Enter a five-digit number: ");
num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    for (t = num; num != 0; num = num / 10)
    {
        r = num % 10;
        sum = sum * 10 + r;
    }
    if (t == sum)
        Console.Write($"{t} is a palindrome, ");
    else
        Console.Write($"{t} is not a palindrome, ");
}
else
    Console.Write("Enter a five-digit number! ");

