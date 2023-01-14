// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Input first number");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine("Numbers are equal.");
}
else if (number2 > number1)
{
    Console.WriteLine("max = " + number2 + "; Second number is bigger.");
}

else
{
    Console.WriteLine("max = " + number1 + "; First number is bigger.");
}