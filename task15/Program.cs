// Напишите программу, которая принимает на вход
// цифру, обозначающую день недели, и проверяет, является ли
// этот день выходным.

Console.WriteLine("Введите день недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine());

if (number >=1 & number <=7)
{
    if (number ==6 | number ==7)
    {
        Console.WriteLine("Это день недели выходной");
    }
    else
    {
        Console.WriteLine("Это день недели рабочий"); 
    }
}
else 
{
    Console.WriteLine("Такого дня недели не существует :)");
}