// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

void holidayChecker(int dayNum)
{
    if (dayNum < 1 || dayNum >7)
    {
        Console.WriteLine("Wrong Input");
    }
    else if (dayNum == 6 || dayNum ==7)
    {
        Console.WriteLine("It's a holiday!!!");
    }
    else
    {
        Console.WriteLine("Nope(");
    }
}

holidayChecker(num);

