// Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.
Console.WriteLine("Enter any positive number");
string numStr = Console.ReadLine();
int num = Convert.ToInt32(numStr);

for (int i = 1; i <= num; i++)
{
if (i % 2 == 0 ) 
{
   Console.Write($"{i} "); 
}
}


