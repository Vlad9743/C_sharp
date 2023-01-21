// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// The Way Of Integer

/*
Console.Write("Input 5-didgit number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000 || num > 99999)
{
Console.WriteLine("Wrong input.");
}

else
{
    int[] digits = new int[5];

    for (int i = 4; i >= 0; i--)
    {
        digits[i] = num % 10;
        num /= 10;
        //Console.WriteLine(digits[i]);
    }

    if (digits[4] == digits[0] && digits[3] == digits[1]) Console.WriteLine("The number is a palindrome.");
    else Console.WriteLine("The number is not a palindrome.");
}

*/

//The Way Of String

Console.Write("Input 5-didgit number: ");
string num = Console.ReadLine();

if (num.Length != 5) Console.WriteLine("Wrong input.");
else if (num[0] == num[4] && num[1] == num[3]) Console.WriteLine("The number is a palindrome.");
else Console.WriteLine("The number is not a palindrome.");