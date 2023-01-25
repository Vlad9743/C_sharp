// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Input number: ");
int inputNum = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int num)
{
    num = Math.Abs(num);//чтобы цикл сработал для отрицательный чисел

    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("The sum of the digits in " + inputNum + " is equal to ");
Console.WriteLine(SumOfDigits(inputNum));
