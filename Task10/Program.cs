// Напишите программу, которая принимает
// на вход трехзначное число и на
// выходе показывает вторую цифру этого числа
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Enter three-digit number > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("You did not enter a three-digit number, please re-enter");
    return;
}
Console.WriteLine($"Entered number `{number}`");
int secondRank = number / 10 % 10;
Console.WriteLine($"Second digit `{secondRank}`");
