//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumFromMToN(int startSum, int endSum)
{
    if (startSum == endSum) return endSum;
    return startSum + SumFromMToN(startSum+1,endSum);
}


//main
Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum=0;

if (m == n) sum = m;
else if (m > n) 
{
    sum = SumFromMToN(n,m);
}
else
{
    sum = SumFromMToN(m,n);
}

Console.WriteLine("M="+m+" N="+n+" -> " + sum);


