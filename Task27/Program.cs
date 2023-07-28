// Напишите программу, которая 
// принимает на вход число и 
// выдает сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Promgt(string message)
{
    System.Console.Write(message); //Выводим приглашение кo вводу
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput); //Приводим к числу
    return result; //Возвращаем результат
}

int SumAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Promgt("Enter number: ");
System.Console.WriteLine($"The sum of digits in a number {number} = {SumAllDigit(number)}");
