﻿// Напишите программу, которая 
// 1. на вход принимает три числа, и 
// 2. выдает максимальное из этих чисел.
// Например:
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max) max = b;
if (c > max) max = c;
System.Console.WriteLine("Максимальное из этих чисел="+max);