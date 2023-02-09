//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] Array3dBuilder(int dimentionX, int dimentionY, int dimentionZ)
{
    int[,,] builtArray = new int[dimentionX, dimentionY, dimentionZ];
    int start = 0;
    
    for (int i = 0; i < dimentionX; i++)
    {
        for (int j = 0; j < dimentionY; j++)
        {
            for (int k = 0; k < dimentionZ; k++)
            {
                builtArray[i,j,k] = start;
                start++;
            }
        }
    }

    return builtArray;
}

void Print3dArray(int[,,] originalArray)
{
    for (int i = 0; i < originalArray.GetLength(0); i++)
    {
        for (int j = 0; j < originalArray.GetLength(1); j++)
        {
            for (int k = 0; k < originalArray.GetLength(2); k++)
            {
                Console.Write("|"+originalArray[i,j,k]+"("+i+","+j+","+k+")|");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------");
        }
    }
}

//main
int arrayDimention1 = 5;
int arrayDimention2 = 2;
int arrayDimention3 = 7;

int[,,] newArray = Array3dBuilder(arrayDimention1, arrayDimention2, arrayDimention3);
Print3dArray(newArray);