// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

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

int GetRowSum(int m, int n, int sum)
{
    if (m == n)
    {
        return sum + m;
    }
    else
    {
        sum += n;
        return GetRowSum(m, n - 1, sum);
    }
}

int num1 = GetNumber("Enter first number");
int num2 = GetNumber("Enter second number");
Console.WriteLine(GetRowSum(num1, num2, 0));