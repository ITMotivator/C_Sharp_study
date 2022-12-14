/* Задайте массив заполненный случайными положительными трёхзначными числами. 
/* Напишите программу, которая покажет количество чётных чисел в массиве.

/*Метод получения числа с консоли*/

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

int[] InitArray(int razmer)
{
    int[] arr = new int[razmer];
    Random rnd = new Random();
    for (int i = 0; i < razmer; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

// Метод подсчета четных чисел в массиве

int GetNumOfEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) 
        {
count++;
        }
    }
    return count;
}

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
int evenCount = GetNumOfEvenNumbers(newArr);
PrintArraySign(newArr);
Console.WriteLine($"В массиве четных чисел: {evenCount}");
