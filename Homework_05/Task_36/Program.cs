// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int[] InitArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(-100, 100);
    }
    return arr;
}

// Метод подсчета суммы элементов, стоящих на нечётных позициях.

int GetSumFromOddInd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

// Вывод массива в консоль
void PrintArraySign(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]} ");

    }
    Console.WriteLine();
}

int number = GetSizeMassive("Введите размерность массива: ");
int[] newArr = InitArray(number);
int result = GetSumFromOddInd(newArr);
PrintArraySign(newArr);
Console.WriteLine($"Сумма искомых чисел: {result}");
