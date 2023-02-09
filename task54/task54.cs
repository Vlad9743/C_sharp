//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

void PrintArray(int[,] arrayForPrint)// Функция для вывода массива
{
    for (int i = 0; i < arrayForPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayForPrint.GetLength(1); j++)
        {
            Console.Write(arrayForPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] SortLineDown(int[,] originalArray, int lineNum)//отсортирует по убыванию указанную строку массива
{
    for (int i = 0; i < originalArray.GetLength(1); i++)
    {   
        int temp = 0;
        for (int j = i; j < originalArray.GetLength(1); j++)
        {
            if (originalArray[lineNum,j] > originalArray[lineNum,i])
            {
                temp = originalArray[lineNum,j];
                originalArray[lineNum,j] = originalArray[lineNum,i];
                originalArray[lineNum,i] = temp;
            }
        }
        
    }
    return originalArray;
}

//main
int m = new Random().Next(2,10);
int n = new Random().Next(2,10);
int[,] arr1 = BuildArray(m,n);
Console.WriteLine("-----------------------------------");

for (int k = 0; k < arr1.GetLength(0); k++)
{
    arr1 = SortLineDown(arr1, k);
}

PrintArray(arr1);