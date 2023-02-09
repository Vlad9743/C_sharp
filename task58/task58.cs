//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(1); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            resultMatrix[i,j] = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                resultMatrix[i,j] = resultMatrix[i,j] + firstMatrix[i,k]*secondMatrix[k,j];
            }
        }
    }
    return resultMatrix;
}

//main
int m = 3;
int n = 2;
int o = 3;
int[,] arr1 = BuildArray(m,n); //new int[2,2] {{2,4},{3,2}};
Console.WriteLine("-------------------------------------------------");
int[,] arr2 = BuildArray(n,o); //new int[2,2] {{3,4},{3,3}};
Console.WriteLine("-------------------------------------------------");

if (arr1.GetLength(1) != arr2.GetLength(0)) Console.WriteLine("Multiplication is impossible.");
else
{
    int[,] finalMatrix = MatrixMultiplication(arr1, arr2);
    PrintArray(finalMatrix);
}