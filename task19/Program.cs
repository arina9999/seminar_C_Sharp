// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

int a = (num / 1) % 10;
int b = (num / 10) % 10;
int c = (num / 1000) % 10;
int d = (num / 10000) % 10;

if (a == d & b == c)
{
    Console.WriteLine("Число - палиндром");
}
else if (a < d | b < c | a > d | b > c)
{
    Console.WriteLine("Число НЕ ЯВЛЯЕТСЯ палиндромом");
}

