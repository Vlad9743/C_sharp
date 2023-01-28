// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int arrSize = 10; // Длина массива

int[] BuildArray(int size) // Функция создаст и выведет массив рамера size. 
{
    int[] arr = new int[size];
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(100,1000);
        Console.Write(arr[i] + ", ");
    }
    Console.Write("\b\b");
    Console.Write("]-> ");
    return arr;
}

int EvenCount(int[] array1)//функция посчитает поличество четных элементов в масссиве array1
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i]%2 == 0) count++;
    }
    return count;
}

//main
int[] array2 = BuildArray(arrSize);
Console.WriteLine(EvenCount(array2));
