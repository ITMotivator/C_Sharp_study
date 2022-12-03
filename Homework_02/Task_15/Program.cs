// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

int CreateDay(int a, int b) 
{
    Random num = new Random();
    int res = num.Next(a,b);
    return res;
}

bool IsWeekEnd (int day)
{ 
    bool res = false;
    if (day == 6 || day == 7) 
    {
        res = true;
    }
    return res;
}

int day = CreateDay(1, 8);
Console.WriteLine(day);
Console.WriteLine(IsWeekEnd(day));
