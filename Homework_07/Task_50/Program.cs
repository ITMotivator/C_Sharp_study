// Напишите программу, которая на вход принимает позиции элемента в двумерном 
// массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

//Метод проверки наличия элемента

string CheckPosition(int x, int m, int y, int n, int[,] matrix) {
    int res = 0;
    string strRes = String.Empty;
    if (x <= m && y <=n) 
    {
 res = matrix[x,y];
 strRes = res.ToString();
    }
else strRes = "No such element";
return strRes;
}


int m = GetNumber("Enter number of rows");
int n = GetNumber("Enter number of columns");

int[,] matrix = InitMatrix(m, n);
PrintArray(matrix);

int x = GetNumber("Enter horizontal position");
int y = GetNumber("Enter vertical position");

Console.WriteLine(CheckPosition(x, m, y, n, matrix));

