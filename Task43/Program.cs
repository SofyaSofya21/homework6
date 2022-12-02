﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Программа находит точну пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");

int k1 = ReadInt("Введите значение k1: ");
int b1 = ReadInt("Введите значение b1: ");
int k2 = ReadInt("Введите значение k2: ");
int b2 = ReadInt("Введите значение b2: ");

if(k1==k2 && b1==b2)
    Console.WriteLine("Данные для первого уравнения соответсвуют данным для второго. Это одна и та же прямая.");
else if (k1 == k2)
    Console.WriteLine($"Прямые, соответствующие уравнениям y = {k1}*x + {b1}, y = {k2}*x + {b2}, параллельны. Точек пересечения нет.");
else
{
    int x = (b2-b1)/(k1-k2);
    int y = k1*x+b1;
    Console.WriteLine($"Прямые, соответствующие уравнениям y = {k1}*x + {b1}, y = {k2}*x + {b2}, пересекаются в точке с координатами ({x},{y})");
}



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
