﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FuncAkk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FuncAkk(m - 1, 1);
    else if (m > 0 && n > 0) return FuncAkk(m - 1, FuncAkk(m, n - 1));
}

Console.Clear();

System.Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(FuncAkk(m, n));