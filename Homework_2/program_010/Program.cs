﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

int number = new Random().Next(100, 1000);

int result = (number / 10) % 10;

Console.WriteLine($"{number} => {result}");