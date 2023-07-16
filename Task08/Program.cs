// Напишите программу, которая 
// 1. на вход принимает число (N), а на 
// 2. выходе показывает все четные числа от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <=n; i++)
{
if (i% 2 == 0)
System.Console.Write(i+",");
}
