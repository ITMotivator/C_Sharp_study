// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

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

//Метод создания словаря из непоповторяющихся чисел для заполнения матрицы
Dictionary<int, int> GetUniqueNumbers(int dictSize)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    Random rnd = new Random();
    for (int i = 0; i < dictSize; i++)
    {
        int randomNum = rnd.Next(1, 100);
        if (!dict.ContainsValue(randomNum))
        {
            dict[i] = randomNum;
        }
        else
        {
            do { randomNum = rnd.Next(1, 100); }
            while (!dict.ContainsValue(randomNum));
            dict[i] = randomNum;
        }
        Console.Write($"{dict[i]} ");
    }
    Console.WriteLine();
    return dict;
}

int[,,] Init3dMatrix(int m, int n, int o, Dictionary<int, int> dict)
{
    int[,,] matrix = new int[m, n, o];
    int dictIndex = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = dict[dictIndex];
                dictIndex++;
            }
        }
    }
    return matrix;
}

void Print3dMatrix(int[,,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int m = GetMatrixSizes("Enter size of matrix first dimension");
int n = GetMatrixSizes("Enter size of matrix second dimension");
int o = GetMatrixSizes("Enter size of matrix third dimension");

int dictLength = m * n * o;
Dictionary<int, int> dictForMatrix = GetUniqueNumbers(dictLength);

int[,,] matrix3D = Init3dMatrix(m, n, o, dictForMatrix);
Print3dMatrix(matrix3D);
