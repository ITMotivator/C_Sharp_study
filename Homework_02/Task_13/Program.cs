// Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

Console.Write("Enter any number ");
string numberStr = Console.ReadLine();
int number = int.Parse(numberStr);

if (number > 99)
{
    Console.WriteLine(numberStr[2]);
}
else 
{
   Console.WriteLine("This number has no 3rd digit"); 
}


