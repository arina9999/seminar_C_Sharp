// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] 
// 6, 1, 33 -> [6, 1, 33]


// int[] array = int.Parse(Console.ReadLine());
// Console.Write ("Введите массив из 8 элементов: ");

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i<7; i++)
// Console.Write(array[i] + ",");
//     Console.Write(array[7] + "]");
// }
// PrintArray(array());


Console.Clear();
int[] array = new int[8];
int[] GetNewArray(int[] a)
{
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Введите число: ");
    a[i] = int.Parse(Console.ReadLine()!);
}
return a;
}
void Print(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i<7; i++)
Console.Write(arr[i] + ",");
    Console.Write(arr[7] + "]");
}
Print(GetNewArray(array));