// Напишите программу, которая принимает
// на вход число (N) и выдает таблицу
// квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4 

Console.WriteLine("Enter a positive integer");
int number = Convert.ToInt32(Console.ReadLine());
TableSquare(number);

void TableSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}  {count * count}");
        count++;
    }
}