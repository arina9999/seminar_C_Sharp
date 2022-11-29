// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает 
// все целые числа в промежутке от -N до N.
// 4-> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2-> "-2, -1, 0, 1, 2"


Console.Write("Введите любое число: ");
int N = int.Parse(Console.ReadLine());

int count = -N;

while (count < N + 1)
{
    Console.Write(count + " ");
    count = count + 1;
}