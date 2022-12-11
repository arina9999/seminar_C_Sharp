//  Напишите программу, которая принимает на вход число N // и выдаёт произведение чисел от 1 до N. 
// 4 -> 24 
// 5 -> 120

Console.Clear();
Console.Write ("Введите любое число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Произведение чисел = {GetProdNums(n)}");

int GetProdNums(int number)
{
    int prod = 1;
    while (number > 0)
     {
        prod *= number;
        number --;
     }
     return prod;
}
