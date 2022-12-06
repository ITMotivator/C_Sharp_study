// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// d = √(x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2

int GetCoordinates(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Error! Please enter number.");
        }
    }

    return result;
}

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return Math.Round(dist, 2);
}

int x_1 = GetCoordinates("Enter x1: ");
int y_1 = GetCoordinates("Enter y1: ");
int z_1 = GetCoordinates("Enter z1: ");
int x_2 = GetCoordinates("Enter x2: ");
int y_2 = GetCoordinates("Enter y2: ");
int z_2 = GetCoordinates("Enter z2: ");

double d = GetDistance(x_1, y_1, z_1, x_2, y_2, z_2);
Console.WriteLine($"Distance is {d}");

