// Напишите программу, которая принимает
// на вход три числа и проверяет, может ли 
// существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона 
// треугольника меньше суммы двух других сторон.

Console.Write("Enter the first side of the triangle: ");
int firstSide = int.Parse(Console.ReadLine());

Console.Write("Enter the second side of the triangle: ");
int secondSide = int.Parse(Console.ReadLine());

Console.Write("Enter the third side of the triangle: ");
int thirdSide = int.Parse(Console.ReadLine());

bool isTriangle = IsTriangleExists(firstSide, secondSide, thirdSide);

Console.WriteLine(isTriangle ? "The triangle exists " : "The triangle does not exist");

bool IsTriangleExists(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}
