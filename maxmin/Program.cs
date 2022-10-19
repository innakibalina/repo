//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7

Console.WriteLine("Какое число большее, какое меньшее?");
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b)
{
Console.WriteLine("Число a - максимальное, b - минимальное");
}
    else {
        Console.WriteLine("Число b - максимальное, a - минимальное");
    }
