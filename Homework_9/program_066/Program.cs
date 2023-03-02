// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int m, int n)
{
    int sum = m;
    if (m == n) return sum;
    return sum + Sum(m + 1, n);
}

Console.Clear();

System.Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

System.Console.WriteLine(Sum(m, n));