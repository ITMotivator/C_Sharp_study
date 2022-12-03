// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
int CreateNum(int a, int b) 
{
    Random num = new Random();
    int res = num.Next(a,b);
    return res;
}

int Show2ndDigit (int num)
{
    int res = (num / 10) % 10;
    return res;
}

int number = CreateNum(100, 1000);
Console.WriteLine(number);
Console.WriteLine(Show2ndDigit(number));