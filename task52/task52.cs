//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] BuildArray(int rows, int columns)// Функция для создания массива
{
    int[,] arr = new int[rows,columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(0,11);
            Console.Write(arr[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return arr;
}

double[] AverageCalc (int[,] arr2)
{
    double[] average = new double[0];
    for (int i = 0; i < arr2.GetLength(1); i++)
    { double columnSum = 0;
        for (int j = 0; j < arr2.GetLength(0); j++)
        {
            columnSum += arr2[j,i];
        }
    Array.Resize(ref average, average.Length + 1);
    average[average.Length - 1] = Math.Round(columnSum / arr2.GetLength(0), 2);
    }
    return average;
}

//main
int m = new Random().Next(2,10);
int n = new Random().Next(2,10);
int[,] arr1 = BuildArray(m,n);
double[] average1 = AverageCalc(arr1);

Console.WriteLine("Columns average: ");
for (int k = 0; k < average1.Length; k++)
{
    Console.Write(average1[k] + "\t");
}




