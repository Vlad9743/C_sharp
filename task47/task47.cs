// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] BuildArray(int rows, int columns)
{
    double[,] arr = new double[rows,columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(new Random().NextDouble() * 10 - 5, 2);
            Console.Write(arr[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return arr;
}

//main

double[,] array1 = BuildArray(m,n);