// Напишите программу, которая по заданному 
// номеру четверти, показывает диапазон возможных
// точек в этой четверти (x и y).

Console.WriteLine("Enter the quarter number");
string quarter = Console.ReadLine();

string coordinatesRange = GetCoordinates(quarter);
Console.WriteLine(coordinatesRange == null ? "Input error" : coordinatesRange);

string GetCoordinates(string quarterNumber)

{
    if (quarter == "1") return "x > 0, y > 0";
    if (quarter == "2") return "x < 0, y > 0";
    if (quarter == "3") return "x < 0, y < 0";
    if (quarter == "4") return "x > 0, y < 0";
    return null;
}
