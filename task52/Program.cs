// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] CreateArray(int a, int b)
{
    int[,] matrix = new int[a, b];
    for (int rows = 0; rows <matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns <matrix.GetLength(0); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 10);
            Console.Write($"{matrix[rows,columns]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}

void Average(int[,] array)
{
    Console.Write("\nСреднееарифметическое каждого столбца = ");
    for (int columns = 0; columns <array.GetLength(1); columns++)
    {
        double sumElem = 0;
        for (int rows = 0; rows <array.GetLength(0); rows++)
        {
           sumElem += array[rows,columns];
        }
        double averegeElem = Math.Round(sumElem/array.GetLength(0), 1);
        Console.Write($"{averegeElem} ");
    }
}
    Console.WriteLine("Введите размер массива (количество столбцов и строк) без пробела: ");
    int size = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    Average(CreateArray(size/10, size%10));
    Console.WriteLine();