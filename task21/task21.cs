// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//ввод первой точки
Console.Write("Input point One coordinates in x;y;z format:");
string temp = Console.ReadLine();
string[] pointOne = temp.Split(';'); //разделил введенную строку 

double[] pointOneCoord = new double[3]{0,0,0}; // этот блок преобразует строку в числа
for (int i = 0; i <= 2; i++)
{
    pointOneCoord[i] = Convert.ToDouble(pointOne[i]);
}

//ввод второй точки
Console.Write("Input point Two coordinates in x;y;z format:");
temp = Console.ReadLine();
string[] pointTwo = temp.Split(';'); //разделил введенную строку 

double[] pointTwoCoord = new double[3]{0,0,0}; // этот блок преобразует строку в числа
for (int i = 0; i <= 2; i++)
{
    pointTwoCoord[i] = Convert.ToDouble(pointTwo[i]);
}

//вычисление расстояния

double dist = Math.Round(Math.Sqrt(Math.Pow((pointTwoCoord[0]-pointOneCoord[0]),2) + Math.Pow((pointTwoCoord[1]-pointOneCoord[1]),2) + Math.Pow((pointTwoCoord[2]-pointOneCoord[2]),2)),3);

Console.WriteLine("Distance between point One (" + pointOneCoord[0] + ";" + pointOneCoord[1] + ";"+ pointOneCoord[2] + 
") and point Two (" + pointTwoCoord[0] + ";" + pointTwoCoord[1] + ";" + pointTwoCoord[2] + ") is : " + dist );
