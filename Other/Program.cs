int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        /*
        2 типа данных: reference types(ссылочные) и value types(значимые)
        */

        if(int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Введите корректное число");
        }
    }

    return result;
}

int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    if(x < 0 && y > 0)
        return 2;
    if(x < 0 && y < 0)
        return 3;
        
    return 4;
}

int x = GetNumber("Введите х:");
int y = GetNumber("Введите y:");

int quarter = GetQuarter(x,y);

Console.WriteLine($"точка с координатами ({x},{y}) лежит в {quarter} четверти");


