// Напишите программу, которая заполнит спирально массив 4 на 4.

int matrix1stDirSize = 4;
int matrix2ndDirSize = 4;

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    int k = 1;//цифры для заполнения массива
    int countX = m;// определяет количество строк для прохода
    int countY = n;//определяет количество столбцев для прохода
    int posX = 0;//индексы по первому измерению
    int posY = 0;//индексы по второму измерению
    while (countX + countY - 1 > 1)//заполняем один круг за цикл
    {
        for (int j = 0; j < countY; j++)//заполняем строку вправо
        {
            matrix[posX, posY] = k;
            posY++;
            k++;
        }
        posX++; //спускаемся на строку вниз
        posY--; //возвращаемся в диапазон по столбцу
        for (int i = 0; i < countX - 1; i++) /*заполняем столбец вниз.
        Т.к. одну строку уже прошли, при проходе по столбцу вниз будет на одну 
строку меньше(i < countX - 1)*/
        {
            matrix[posX, posY] = k;
            posX++;
            k++;
        }
        posY--;//переходим на столбец влево
        posX--;//возвращаемся в диапазон по строке
        countX--;
        countY--;

        for (int j = 0; j < countY; j++)//заполняем строку влево
        {
            matrix[posX, posY] = k;
            posY--;
            k++;
        }
        posX--;//поднимаемся на строку вверх
        posY++;//возвращаемся в диапазон по столбцу
        for (int i = 0; i < countX - 1; i++)//заполняем столбец вверх
        {
            matrix[posX, posY] = k;
            posX--;
            k++;
        }
        posY++; 
        posX++;
        countX--;
        countY--;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > 9)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            else
            {
                Console.Write($"0{matrix[i, j]} ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] spiralMatrix = InitMatrix(matrix1stDirSize, matrix2ndDirSize);
PrintMatrix(spiralMatrix);