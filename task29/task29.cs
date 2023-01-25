// Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

//Первая пара переменных определяет диапазон в котором задается размер массива
Console.Write("Input the beginning of the array length range: ");
int arrLengthStart = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the end of the array length range: ");
int arrLengthEnd = Convert.ToInt32(Console.ReadLine());

//Вторая пара переменных определяет диапазон в котором задаются значения элементов
Console.Write("Input the beginning of the elements range: ");
int elemRangeStart = Convert.ToInt32(Console.ReadLine());

Console.Write("Input the end of the elements range: ");
int elemRangeEnd = Convert.ToInt32(Console.ReadLine());

int[] ArrayBuilder(int arrLengthStart0, int arrLengthEnd0, int elemRangeStart0, int elemRangeEnd0)
{
    int arrLenght = new Random().Next(arrLengthStart0, arrLengthEnd0 + 1); // генерирую длину массива
    int[] arrRandom = new int[arrLenght]; // массив сгенерированной длины

    for (int i = 0; i < arrLenght; i++) //заполнение массива
    {
        arrRandom[i] = new Random().Next(elemRangeStart0, elemRangeEnd0 +1 );
        Console.Write(arrRandom[i] + " ");
    }

    return arrRandom;
}

ArrayBuilder(arrLengthStart, arrLengthEnd, elemRangeStart, elemRangeEnd);
