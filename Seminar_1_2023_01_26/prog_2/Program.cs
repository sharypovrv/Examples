// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Clear();

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine()!);

if (numA == numB * numB)
{
    Console.WriteLine($"Число {numA} является квадратом числа {numB}.");
}
else
{
    Console.WriteLine($"Число {numA} НЕ является квадратом числа {numB}.");
}