// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
Console.WriteLine("Enter first number");
string numStr1 = Console.ReadLine();
int num1 = Convert.ToInt32(numStr1);

Console.WriteLine("Enter second number");
string numStr2 = Console.ReadLine();
int num2 = Convert.ToInt32(numStr2);

if (num1 > num2) 
{
    Console.WriteLine($"max = {num1}");
} 
else if (num2 > num1) 
{
   Console.WriteLine($"max = {num2}"); 
} 
else 
{
    Console.WriteLine("Numbers are equal");
}

