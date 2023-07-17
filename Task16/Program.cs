// Напишите программу, которая принимает
// 1. на вход два числа и проверяет, является ли
// 2. одно число квадратом другого.
// Например:
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> нет

Console.WriteLine("Enter first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int number2 = Convert.ToInt32(Console.ReadLine());

bool res = IsSquareTwoNumbers(number1, number2);
Console.WriteLine(res ? "Yes" : "No");

bool IsSquareTwoNumbers(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}
