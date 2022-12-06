// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.


bool CheckIfPalindromic(int num)
{
    string numStr = num.ToString();
    if (numStr[0] == numStr[4] && numStr[1] == numStr[3])
        return true;
    else
        return false;
}

Console.WriteLine(CheckIfPalindromic(14212));
Console.WriteLine(CheckIfPalindromic(12821));
Console.WriteLine(CheckIfPalindromic(23432));