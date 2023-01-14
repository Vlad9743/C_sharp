// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int counter = 2;

if (number < 2)
{
    Console.WriteLine("Sorry. There are no such numbers.");
}
else
{
    while (counter <= number)
    {
        Console.Write(counter + " ");
        counter+=2;    }
}