//Задача 0 // // Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// // на само себя).

// // Например:
// // 4 -> 16 
// // -3 -> 9 
// // -7 -> 49

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// int sqrt = number * number;

// Console.WriteLine("Квадрат числа = " + sqrt);

//Задача 0 от 02.12
// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// int num = new Random().Next(10, 100);
// int a1 = num / 10;
// int a2 = num % 10;
// int max = a1;
// if (max < a2)
// {
//     max = a2;
// }
// Console.WriteLine($"Максимальная цифра в числе {num} --> {max}");

int num = new Random().Next(10, 100);
int a1 = num / 10;
int a2 = num % 10;

if (a1 < a2)
{
    Console.WriteLine("Максимальная цифра в числе" + num + "-->" + a2);
}
else if (a1 > a2)
{
    Console.WriteLine("Максимальная цифра в числе" + num + "-->" + a1);
}
else
{
    Console.WriteLine("Числа равны");
}