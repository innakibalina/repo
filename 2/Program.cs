// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да

Console.WriteLine("Четное ли число?");
Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine()!);
if (a % 2 == 0)
{
Console.WriteLine("да");
}
    else {
        Console.WriteLine("нет");
    }