﻿// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число 
//квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число a: ");
int numbera = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int numberb = int.Parse(Console.ReadLine());

if (numbera == numberb * numberb)
{
    Console.WriteLine("YES");
}
else 
{
    Console.WriteLine("NO");
}



