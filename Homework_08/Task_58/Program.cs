//  Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.

int GetMatrixSizes(string message)
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

void PrintMatrix(int[,] matrix)
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

//Метод проверки матриц на условия возможности их перемножения
bool CheckIfMultiplicationPossible(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(0) == matrix2.GetLength(1) &&
    matrix1.GetLength(1) == matrix2.GetLength(0))
        return true;
    else
    {
        Console.WriteLine("Can't multiply these matrixes. Restart.");
        return false;
    }
}

//Метод перемножения матриц
int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (CheckIfMultiplicationPossible(matrix1, matrix2))
    {

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {

            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
    }
    return resultMatrix;
}

int m = GetMatrixSizes("Enter number of rows of first matrix");
int n = GetMatrixSizes("Enter number of columns of first matrix");
int[,] matrixA = InitMatrix(m, n);

int x = GetMatrixSizes("Enter number of rows of second matrix");
int y = GetMatrixSizes("Enter number of columns of second matrix");
int[,] matrixB = InitMatrix(x, y);

PrintMatrix(matrixA);
PrintMatrix(matrixB);
int[,] result = MatrixMultiplication(matrixA, matrixB);
PrintMatrix(result);