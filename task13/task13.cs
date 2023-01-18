// Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.
Console.Write("Inpun number: ");
int num = Convert.ToInt32(Console.ReadLine());
int lastDigit = 0;

if (num < 100)
{
    Console.WriteLine("There is no third digit.");
}

else
{
    while (num > 100)
    {
        lastDigit = num % 10;
        num /= 10;
    }
    Console.WriteLine("The third digit is: " + lastDigit);
}