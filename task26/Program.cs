// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе. 
// 456 -> 3 
// 78 -> 2 
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int numberTemp = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе = {GetCount(numberTemp)}");

int GetCount(int numberTemp)
{
    int count = 0;
    while (numberTemp > 0)
    {
        numberTemp /= 10;
        count ++;
    }
    return count;
}
