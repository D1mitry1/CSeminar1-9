// Напишите программу, которая 
// 1. на вход принимает число, и 
// 2. выдает, является ли число четным (делится ли оно на два без остатка).
// Например:
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a% 2 == 0)
System.Console.WriteLine("Число:"+a+"четное");
else
System.Console.WriteLine($"Число:{a}нечетное");
