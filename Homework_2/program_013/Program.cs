// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

// int number = new Random().Next(-1000000, 1000000);
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int abs = Math.Abs(number);

if (abs / 100 == 0) Console.WriteLine($"У числа {number} нет третьей цифры.");
else
{
    int third = (abs / 100) % 10;
    Console.WriteLine($"У числа {number} третье число это {third}.");
}