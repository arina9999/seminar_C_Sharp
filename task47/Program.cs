﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


Console.WriteLine("Введите размер столбца массива М: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер строки массива N: ");
int n = int.Parse(Console.ReadLine()!);
CreateArray(m, n);
Console.WriteLine();

void CreateArray(int a, int b)
{
    double[,] matrix = new double[a, b];
    for (int rows = 0; rows <matrix.GetLength(0); rows++)
    {
        for (int colums = 0; colums < matrix.GetLength(1); colums++)
        {
            matrix[rows, colums] = new Random().Next(-9, 10) + Math.Round(new Random().NextDouble(), 1);
            Console.Write($"{matrix[rows, colums]} ");
        }
        Console.WriteLine();
    }
}