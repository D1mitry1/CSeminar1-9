// Напишите цикл, который принимает
// на вход два числа (А и В) и 
// возводит число А в натуральную степень В.
// 3, 5 -> 243 (3^5)
// 2, 4 -> 16


int numberA = ReadInt("Enter number A: ");
int numberB = ReadInt("Enter number B: ");
ToDegree(numberA, numberB);

// Фукция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
//Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
