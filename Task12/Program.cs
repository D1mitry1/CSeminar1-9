// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Enter the first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int reminder = IsMultiple(firstNum, secondNum);
if (reminder == 0) Console.Write("Multiple");
else Console.Write($"Not multiple, remains {reminder} ");

int IsMultiple(int firstNumber, int secondNumber)
{
    return firstNumber % secondNumber;
}
