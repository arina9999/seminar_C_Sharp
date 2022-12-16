// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] CreateArray()
{
    double[] array = new double[5];
    Console.WriteLine("Массив ");
    for (int i = 0; i < 5; i++)
    {
        array[i] = 100 * Math.Round(new Random().NextDouble(), 4);
        Console.Write($"{array[i]}");
    }
    Console.WriteLine("\n");
    return array;
}
void Diff(double[] myArray)
{
    int max = 0;
    int min = 0;
    for(int i = 0; i < myArray.Length; i++)
        {
            if (myArray[i] > myArray[max])
            max = i;
            if (myArray[i] < myArray[min])
            min = i;
        }
        Console.WriteLine($"Разница между максимальным и манимальным элементами = {Math.Round(myArray[max] - myArray[min], 2)}");
}
Diff(CreateArray());





