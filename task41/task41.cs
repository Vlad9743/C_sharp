//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] BuildArray()//функция для задания массива
{
    Console.WriteLine("Input number and press Enter. Input 'q' to stop.");

    int[] array1 = new int[0];//изначально массив нулевой длины
    int counter = 0;

    while (true)//бесконечный цикл на считывание
    {
        string newNumber = Console.ReadLine();
        if (newNumber == "q") break;// при вводе q - выход из цикла
        else
        {
            Array.Resize(ref array1, array1.Length + 1);//добавляю элемент в массив
            array1[counter] = Convert.ToInt32(newNumber);
            counter++;    
        }
    }
    return array1;
}


int PosCount (int[] array2)// фунция на подсчет количества положительных элементов
{
    int positiveCount = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write(array2[i] + ", ");
        if (array2[i] > 0) positiveCount++;

    }

    Console.Write("\b\b");

    return positiveCount;
}
//main
int[] InputArray = BuildArray();
Console.WriteLine(" -> " + PosCount(InputArray));