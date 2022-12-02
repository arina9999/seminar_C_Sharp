// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b & a >= c)
{
    Console.WriteLine("Максимальное число: a");
}
else if (b >= a & b >= c)
{
    Console.WriteLine("Максимальное число: b");
} 
else if (c >= a & c >= b)
{
    Console.WriteLine("Максимальное число: c");
}
else
{
    Console.WriteLine("Числа равны");
}