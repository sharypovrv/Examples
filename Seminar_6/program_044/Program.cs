﻿// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int[] NumberFib(int number)
{
    int[] result = new int[number];
    if (number >= 1) result[0] = 0;
    if (number >= 2) result[1] = 1;

    for (int i = 2; i < number; i++)
    {
        result[i] = result[i - 1] + result[i - 2];
    }

    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(string.Join(", ", NumberFib(number)));