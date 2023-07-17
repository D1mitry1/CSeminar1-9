// Напишите программу, которая принимает 
// на вход число и проверяет, кратно ли 
// оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да 

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());

bool num = IsMultiple(number);
Console.WriteLine(num ? "Yes" : "No");

bool IsMultiple(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}