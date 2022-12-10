// Напишите цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.

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

int GetPow(int num1, int num2) 
{
    int res = 1;
    for (int i = 0; i < num2; i++)
    {
        res *= num1;
    }
    return res;
}

int number1 = GetNumber("Enter first number");
int number2 = GetNumber("Enter second number");
int result = GetPow(number1, number2);
Console.WriteLine($"{number1} in pow of {number2} = {result}");