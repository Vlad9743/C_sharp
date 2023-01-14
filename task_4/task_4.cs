// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int[] numbers = new int[3];

Console.WriteLine("Input first number:");
numbers[0] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number:");
numbers[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number:");
numbers[2] = Convert.ToInt32(Console.ReadLine());

int max = numbers[0];
int count = 0;

while (count <3)
{
    if (max < numbers[count])
    {
        max = numbers[count];
    }
    count+=1;
}

Console.WriteLine("Max number is: " + max);