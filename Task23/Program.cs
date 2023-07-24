// Напишите программу, которая принимает
// на вход число (N) и выдает таблицу
// кубов чисел от 1 до N
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125 

Console.WriteLine("Enter a positive integer");
int number = Convert.ToInt32(Console.ReadLine());
TableCube(number);

void TableCube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count}  {count * count * count}");
        count++;
    }
}