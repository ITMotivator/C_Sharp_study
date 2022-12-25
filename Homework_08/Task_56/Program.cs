// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Not a number");
        }
    }
    return result;
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }

    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Метод нахождения строки с наименьшей суммой
int GetLineWithMinSum(int[,] matrix)
{
    int minLineIndex = 0;
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[0,j];
    }
    int minSum = sum;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        sum = 0;
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
        sum += matrix[i,j];
       } 
       if (sum < minSum) 
       {
        minSum = sum;
        minLineIndex = i;
       }
    }
    return minLineIndex;
} 

int m = GetNumber("Enter number of rows");
int n = GetNumber("Enter number of columns");

int[,] matrix = InitMatrix(m, n);
PrintArray(matrix);
int result = GetLineWithMinSum(matrix);
Console.WriteLine($"Line index: {result}");