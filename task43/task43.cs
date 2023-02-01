//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Input k1: ");
double input_k1 = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

Console.Write("Input b1: ");
double input_b1 = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

Console.Write("Input k2: ");
double input_k2 = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

Console.Write("Input b2: ");
double input_b2 = Math.Round(Convert.ToDouble(Console.ReadLine()), 2);

void IntersectionCheck(double k1, double b1, double k2, double b2)//Функция поиска точки пересечения
{
    if (k1 == k2 && b1 == b2) Console.WriteLine("Lines are colinear.");
    else if (k1 == k2) Console.WriteLine("Lines are parallel.");
    else
    {
        double x = Math.Round((b2 - b1)/(k1 -k2), 2);
        double y = Math.Round(k1 * x + b1, 2);
        Console.WriteLine("Intersection point: (" + x + "; "+ y + ").");
    }
}

//main
IntersectionCheck(input_k1, input_b1, input_k2, input_b2);

