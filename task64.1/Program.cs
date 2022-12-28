// Задача 64: Задайте значение N. Напишите программу, которая выведет 
//  натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

string NumbersNatural(int number)
{
    string num = Convert.ToString(number);
    if (number == 1) return "1";
    else
    {
        number--;
        return num + ", " + NumbersNatural(number);
    }
}

Console.WriteLine($"Натуральные числа в промежутке от 1 до N: {NumbersNatural(number)}");