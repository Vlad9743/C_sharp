//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int FindMinSumLine(int[,] originalArray)
{
    int minSumLineNumber = 0;
    int minSum = 0;

    for (int k = 0; k < originalArray.GetLength(1); k++)
    {
        minSum += originalArray[0,k];
    }

    int tempSum = 0;

    for (int i = 1; i < originalArray.GetLength(0); i++)
    {
        tempSum = 0;
        for (int j = 0; j < originalArray.GetLength(1); j++)
        {
            tempSum += originalArray[i,j];
        }
        if (tempSum < minSum)
        {
            minSum = tempSum;
            minSumLineNumber = i;
        }
    }

    return minSumLineNumber;
}

//main
int m = 6;//new Random().Next(2,10);
int n = 5;//m + (new Random().Next(2,7) * new Random().Next(-1,2)) + 1;//более сложная формула, чтобы массив был прямоугольным
int[,] arr1 = BuildArray(m,n);
Console.WriteLine("-----------------------------------");
Console.WriteLine("Line number " + FindMinSumLine(arr1) + " contains minimal summ.");