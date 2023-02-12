//Задача 64: Задайте значение N.
//Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

int MinusOne(int number)
{
    Console.Write(number + ", ");
    if (number == 1) return 1;
    return MinusOne(number-1);
}

//main
Console.Write("Input N:");
int num = Convert.ToInt32(Console.ReadLine());
MinusOne(num);