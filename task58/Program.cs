﻿// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк для первого массива ");
int rowsFirst = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для первого массива ");
int columnsFirst = int.Parse(Console.ReadLine()!);
int[,] arrayFirst = new int[rowsFirst, columnsFirst];
arrayFirst = CreateArray(rowsFirst, columnsFirst);
Console.WriteLine();
PrintArray(arrayFirst);
Console.WriteLine();

Console.Write("Введите количество строк для второго массива ");
int rowsSecond = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для второго массива ");
int columnsSecond = int.Parse(Console.ReadLine()!);
int[,] arraySecond = new int[rowsSecond, columnsSecond];
arraySecond = CreateArray(rowsSecond, columnsSecond);
Console.WriteLine();
PrintArray(arraySecond);
Console.WriteLine();


int[,] MatrixMultiplication(int[,] arrayFirst, int[,] arraySecond)
{
    int[,] resultArray = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];

    if (arrayFirst.GetLength(1) != arraySecond.GetLength(0))
    {
        Console.WriteLine("Произведение массивов невозможно");
        int[,] emptyArray = { };
        return emptyArray;
    }
    else
    {

        for (int i = 0; i < arrayFirst.GetLength(0); i++)
        {
            for (int t = 0; t < arraySecond.GetLength(1); t++)
            {
                int tempSum = 0;

                for (int j = 0; j < arrayFirst.GetLength(1); j++)
            
                {
                    tempSum += arrayFirst[i, j] * arraySecond[j, t];
                }
            
                resultArray[i, t] = tempSum;
            }
        }
        Console.WriteLine("Произведение массивов допустимо ");
        Console.WriteLine();
        return resultArray;
    }
}



PrintArray(MatrixMultiplication(arrayFirst, arraySecond));
Console.WriteLine();