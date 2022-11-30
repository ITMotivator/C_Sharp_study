// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Enter first number ");
string numStr1 = Console.ReadLine();
int num1 = Convert.ToInt32(numStr1);

Console.Write("Enter second number ");
string numStr2 = Console.ReadLine();
int num2 = Convert.ToInt32(numStr2);

Console.Write("Enter third number ");
string numStr3 = Console.ReadLine();
int num3 = Convert.ToInt32(numStr3);

if (num1 == num2 && num2 == num3)
{
    Console.WriteLine("All numbers are equal");
}
else{
int max = num1;
if (num2 > max) 
{
    max = num2;
} 
if (num3 > max) 
{
   max = num3; 
} 
 Console.WriteLine($"max = {max}");
}