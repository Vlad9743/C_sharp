//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.


string[,] SpiralFillArray(int dimention)
{
    string[,] spiralArray = new string[dimention,dimention];
    

    ///////////////////////заполнил нулями, чтобы проще отслеживать последующее заполнение
    for (int i = 0; i < dimention; i++)
    {
        for (int j = 0; j < dimention; j++)
        {
            spiralArray[i,j] = "00";
        }
    }
    //////////////////////

    int currentNum = 1;//переменная для текущего значения, записываемого в ячейки массива
    int currentPositionY = 0;//переменные для координат текущей ячейки 
    int currentPositionX = 0;
    int sizeModifier = 0;//показывает на сколько элементов меньше нужно заполнить вдоль одной стороны при сужении спирали
    
    while (currentNum <= dimention*dimention)
    {
        string currentNumString = string.Empty;//переменная для организации красивого вывода
        if (currentNum > 9) currentNumString = Convert.ToString(currentNum);
        else currentNumString = "0" + Convert.ToString(currentNum);

        spiralArray[currentPositionY,currentPositionX] = currentNumString;

        if (currentPositionY == sizeModifier && currentPositionX < dimention - 1 - sizeModifier)
        currentPositionX++; //движение вправо по верхнему краю

        else if (currentPositionX == dimention - 1 - sizeModifier && currentPositionY < dimention - 1 - sizeModifier)
        currentPositionY++; //движение вниз по правому краю

        else if (currentPositionY == dimention - 1 - sizeModifier && currentPositionX > sizeModifier)
        currentPositionX--; //движение влево по нижнему краю

        else if (currentPositionX == sizeModifier && currentPositionY < dimention - sizeModifier)
        currentPositionY--; //движение вверх по левому краю

        currentNum++;

        if (currentPositionY == sizeModifier + 1 && currentPositionX == sizeModifier) sizeModifier++;//условие начала следующего витка
        
        //Console.WriteLine(currentPositionY + "-" + currentPositionX);//вывод текущей позиции для отладки
    }

    return spiralArray;
}

void PrintArray(string[,] arrayForPrint)// Функция для вывода массива
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

//main
int arrayDimention = 4;
string[,] arr1 = SpiralFillArray(arrayDimention);
PrintArray(arr1);