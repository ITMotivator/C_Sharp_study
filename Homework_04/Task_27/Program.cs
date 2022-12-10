// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

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

int SumOfNumDigits(int num)
{
    int sum = 0;
    int lastDigit = num % 10; 
    while (num > 0)
    {
        sum += lastDigit;
        num /= 10;
        lastDigit = num % 10;
    }
    return sum;
}

int number = GetNumber("Enter some number");
int result = SumOfNumDigits(number);
Console.WriteLine(result);