//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет
//1 1 -> 9


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

//main
int m = new Random().Next(2,10);
int n = new Random().Next(2,10);
int[,] arr1 = BuildArray(m,n);

Console.WriteLine("Input element index: ");
string[] numberIndex = (Console.ReadLine()).Split(" ");

int columnNumber = Convert.ToInt32(numberIndex[1]);
int rowNumber = Convert.ToInt32(numberIndex[0]);
if (columnNumber > arr1.GetLength(0) || rowNumber > arr1.GetLength(1))
{
    Console.WriteLine("There is no such element");
}
else Console.WriteLine("-> " + arr1[rowNumber, columnNumber]);
