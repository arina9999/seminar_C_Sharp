// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите любое трехзначное число: ");
int N = int.Parse(Console.ReadLine());

int length = N.ToString().Length;
int result = 0;

if (length == 3)
{
    result = N % 10;
    Console.WriteLine(result);
}
else 
{
    Console.WriteLine("Введите трехзначное число");
}