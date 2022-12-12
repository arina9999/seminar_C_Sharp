// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine()!);

void Product(int a, int b)
{
    int i = 1;
    int prod = 1;

    while (i <= b)
    {
        prod = prod * a;
        i++;
    }
    Console.Write($"Число {a}, возведенное в степень {b} равно {prod} ");
}
Product(a, b);

