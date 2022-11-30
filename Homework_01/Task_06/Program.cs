// Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Enter any number");
string numStr = Console.ReadLine();
int num = Convert.ToInt32(numStr);

if (num % 2 == 0 ) 
{
   Console.WriteLine("Number is even"); 
}
else 
{
     Console.WriteLine("Number is odd");
}
