// Напишите программу, которая
// принимает на вход число N и выдает
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Enter a positive integer");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"The product of numbers in the range from 1 to {number} = {factorial}");

int Factorial(int num)

{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        checked // try catch
        {
            fact *= i; // fact = fact * i;
        }

    }
    return fact;
}
