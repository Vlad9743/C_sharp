// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Input 3-digit number:");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999)
{
    Console.WriteLine("Wrong input.");
}
else
{
num /=10;
//Console.WriteLine(num);

num %= 10;
Console.WriteLine("Second digit is: " + num);
}