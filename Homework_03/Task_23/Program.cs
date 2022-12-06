// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Error! Please enter number.");
        }
    }

    return result;
}

void PrintCubeTable(int number)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write($"{i * i * i} ");
    }
}

int number = GetNumber("Enter number");

PrintCubeTable(number);
