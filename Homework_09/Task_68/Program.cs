// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

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

int AkkermanFunc(int m, int n) 
{
if (m == 0) 
{
return n + 1;
} 
else if (n == 0 && m > 0) 
{
    return  AkkermanFunc(m - 1, 1);
}
else
{
    return  AkkermanFunc(m - 1, AkkermanFunc(m, n -1));
}
}

int num1 = GetNumber("Enter first number");
int num2 = GetNumber("Enter second number");
Console.WriteLine(AkkermanFunc(num1, num2));