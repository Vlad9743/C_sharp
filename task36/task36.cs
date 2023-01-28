//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int arrSize = 5; // Длина массива

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

int OddPlacesSum (int[] arrayForSum)//считает сумму элементов массива arrayForSum с нечетными индексами
{
    int sum = 0;
    for (int i = 1; i < arrayForSum.Length; i=i+2)
    {
        sum += arrayForSum[i];
    }
    return sum;
}

//main
int [] array1 = BuildArray(arrSize);
Console.WriteLine(OddPlacesSum(array1));
