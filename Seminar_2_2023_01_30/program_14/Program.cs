﻿// Напишите программу, которая принимает на вход
// число и проверяет, кратно ли оно одновременно
// 7 и 23.
// ● 14 -> нет
// ● 46 -> нет
// ● 161 -> да 

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number % 7 == 0 && number % 23 == 0) Console.WriteLine($"Чиcло {number} кратно одновременно числам 7 и 23.");
else Console.WriteLine($"Чиcло {number} НЕ кратно одновременно числам 7 и 23.");