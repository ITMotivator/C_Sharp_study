// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
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

int[] GetArray(int arrayLength)
{
    int[] arr = new int[arrayLength];
    Random rnd = new Random();
    for (int i = 0; i < arrayLength; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int arrLen = GetNumber("Enter array length");
int[] array = GetArray(arrLen);
PrintArray(array);