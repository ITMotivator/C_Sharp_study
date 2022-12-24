// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

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
            matrix[i, j] = rnd.Next(1, 100);
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

//Метод упорядочивания
int[,] GetSortedMAtrix(int[,] matrix) 
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int[] line = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        line[j] = matrix[i,j];
    }
    Array.Sort(line);
    Array.Reverse(line);
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        newMatrix[i,j] = line[j];
    }
}
return newMatrix;
}

int m = GetNumber("Enter number of rows");
int n = GetNumber("Enter number of columns");

int[,] matrix = InitMatrix(m, n);
PrintArray(matrix);

int[,] sortedMatrix = GetSortedMAtrix(matrix);
PrintArray(sortedMatrix);