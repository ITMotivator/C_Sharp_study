/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.*/

int GetNumbers(string message)
{
    int result;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено не число, повторить ввод");
        }
    }
    return result;
}

//Метод вычисления точки пересечения двух прямых
double[] GetCrossPoint (double k1, double b1, double k2, double b2)
{
    double[] arr = new double[2];
    arr[0] = (b2 - b1) / (k1 - k2);
    arr[1] = k1 * arr[0] + b1;
    return arr;
}

double k1 = GetNumbers("Введите коэффициент K для первой прямой ");
double b1 = GetNumbers("Введите коэффициент B для первой прямой ");
double k2 = GetNumbers("Введите коэффициент K для второй прямой ");
double b2 = GetNumbers("Введите коэффициент B для второй прямой ");
double[] point = GetCrossPoint(k1, b1, k2, b2);
Console.WriteLine($"{point[0]}, {point[1]}");