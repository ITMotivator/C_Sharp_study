// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

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

void GetRow(int number)
{
    if (number == 1)
    {
        Console.Write($"{number} ");
    }
    else
    {
        Console.Write($"{number} ");
        GetRow(number - 1);
    }
}

int num = GetNumber("Enter number");
GetRow(num);