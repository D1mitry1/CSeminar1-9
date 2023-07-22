// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причем X ≠ 0 и Y ≠ 0 и выдает
// номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Enter the coordinates of the point");
Console.WriteLine("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = GetQuarter(xCoordinate, yCoordinate);
string result = quarter > 0
                ? $"The specified coordinates correspond to the quarter -> {quarter}"
                : "Incorrect coordinates have been entered";

Console.WriteLine(result);

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
