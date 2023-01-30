// Задача №11.
// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// ● 456 -> 46
// ● 782 -> 72
// ● 918 -> 98

Console.Clear();

int number = new Random().Next(100, 1000);

int a1 = number / 100;
// int a2 = (number / 10) % 10;
int a3 = number % 10;

int result = a1 * 10 + a3;

Console.WriteLine($"Рандомное число - {number}, результат - {result}");