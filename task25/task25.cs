// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.Write("Input a base : ");
int inputBase = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a power : ");
int inputPower = Convert.ToInt32(Console.ReadLine());

int PowerCycle(int base1, int power)
{
    int result = 1; // присвоил 1, чтобы учесть возведение в нулевую степень
    for (int i = 0; i < power; i++)
    {
        result *= base1;
    }
    return result;
}

Console.Write("A number " + inputBase + " to the power of " + inputPower + " is equal to ");
Console.WriteLine(PowerCycle(inputBase, inputPower));