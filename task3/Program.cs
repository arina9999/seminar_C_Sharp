// Задача 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру
// 3 - среда
// 5 - пятница

Console.WriteLine("Введите день недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine());


if (number == 1)
{
    Console.WriteLine("1й день недели - Понедельник");
}
if (number == 2)
{
    Console.WriteLine("2й день недели - Вторник");
}
if (number == 3)
{
    Console.WriteLine("3й день недели - Среда");
}
if (number == 4)
{
    Console.WriteLine("4й день недели - Четверг");
}
if (number == 5)
{
    Console.WriteLine("5й день недели - Пятница");
}
if (number == 6)
{
    Console.WriteLine("6й день недели - Суббота");
}
if (number == 7)
{
    Console.WriteLine("7й день недели - Воскресенье");
}
else 
{
    Console.WriteLine("Такого дня недели не существует :)");
}