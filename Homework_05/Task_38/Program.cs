// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
// минимальным элементов массива.

int GetSizeMassive(string message)
{
    int result;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено неверное число, повторить ввод");
        }
    }
    return result;
}
// Метод инициализации массива

double[] InitArray(int size)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(-100, 100) + Math.Round(rnd.NextDouble(), 2);
    }
    return arr;
}

// Метод нахождения разницы максимального и минимальным значений в массиве.

double GetDiffMaxAndMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine($"min = {min}; max = {max};");
    diff = max - min;
    return diff;
}

// Вывод массива в консоль
void PrintArraySign(double[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]} ");

    }
    Console.WriteLine();
}

int number = GetSizeMassive("Введите размерность массива: ");
double[] newArr = InitArray(number);
PrintArraySign(newArr);
double result = GetDiffMaxAndMin(newArr);
Console.WriteLine($"Результат: {result}");