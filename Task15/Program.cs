// Напишите программу, которая принимает 
// 1. на вход цифру, обозначающую день недели, 
// 2. и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool IsWeekend(int weekDay)
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}
bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("It's not a day of the week!");
    return false;
}
int weekDay = Prompt("Enter the day of the week > ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Finally a day off");
    }
    else
{
    Console.WriteLine("I'll have to work");
}
}

