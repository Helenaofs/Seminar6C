// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double CrossPointX(double k1, double b1, double k2, double b2)
{
    double x = -(b1 - b2) / (k1 - k2);
    return x;
}

double CrossPointY(double k1, double b1, double x)
{
    double y = k1 * x + b1;
    return y;
}

Console.WriteLine($"Пересечение в точке: ({CrossPointX(k1, b1, k2, b2)}; {CrossPointY(k1, b1, CrossPointX(k1, b1, k2, b2))})");
