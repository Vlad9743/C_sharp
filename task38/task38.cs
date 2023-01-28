// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int arrSize = 10; // Длина массива

int[] BuildArray(int size) // Функция создаст и выведет массив рамера size. 
{
    int[] arr = new int[size];
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-100,101);
        Console.Write(arr[i] + ", ");
    }
    Console.Write("\b\b");
    Console.Write("]-> ");
    return arr;
}

int DiffMinMax (int[] arrayForDiff)//ищем разницу между max и min элементами
{
    int min = arrayForDiff[0];
    int max = arrayForDiff[0];
    for (int i = 0; i < arrayForDiff.Length; i++)
    {
        if (arrayForDiff[i] < min) min = arrayForDiff[i];
        if (arrayForDiff[i] > max) max = arrayForDiff[i];
    }
    return max - min;
}

//main
int[] array1 = BuildArray(arrSize);
Console.WriteLine(DiffMinMax(array1));