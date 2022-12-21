// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CountPosNumbers(string[] listNum)
{
int count = 0;

foreach (string elem in listNum)
    {
        if (int.Parse(elem) > 0)
        count++;
    }
    Console.WriteLine($"Количество чисел больше нуля = {count}");
}
Console.WriteLine("Введите числа через пробел или запятую: ");
string[] list = (Console.ReadLine()!).Split(' ', ',');
CountPosNumbers(list);
