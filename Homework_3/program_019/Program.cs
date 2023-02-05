// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

Console.Clear();

Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);

while (N < 10000 || N >= 100000)
{
    Console.Write("Введите именно пятизначное число: ");
    N = int.Parse(Console.ReadLine()!);
}

int first = N / 10000;
int second = (N / 1000) % 10;
// int third = (N / 100) % 10;
int fourth = (N / 10) % 10;
int fifth = N % 10;

if (first == fifth && second == fourth)
{
    Console.WriteLine($"Число {N} - полиндром.");
}
else
{
    Console.WriteLine($"Число {N} - не полиндром.");
}