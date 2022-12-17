// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int GetNumbers(string message)
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
            Console.WriteLine($"Введено не число, повторить ввод");
        }
    }
    return result;
}

//Метод создания массива (счетчик поместил внутрь, чтобы не писать отдельный метод)

int count = 0;
int[] InitArrayAndCount(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        int nextNum = GetNumbers(" ");
        if (nextNum > 0) count++;
        arr[i] = nextNum;
    }
    return arr;
}

//Метод вывода массива в консоль
void PrintArraySign(int[] massiv)
{
    for (int i = 0; i < massiv.Length; i++)
    {
        Console.Write($"{massiv[i]} ");

    }
    Console.WriteLine();
}



int number = GetNumbers("Введите длину массива: ");
Console.Write($"Введите {number} чисел: ");
int[] newArr = InitArrayAndCount(number);
PrintArraySign(newArr);
Console.WriteLine($"Было введено положительных чисел: {count}");
