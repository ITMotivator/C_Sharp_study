/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        /*
        2 типа данных: reference types(ссылочные) и value types(значимые)
        */

        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите число");
        }
    }

    return result;
}

void PrintSquareTable(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{i * i},");
    }
}

int number = GetNumber("Введите число");

PrintSquareTable(number);

