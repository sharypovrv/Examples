// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool isTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.Clear();
Console.Write("Введите длину первой стороны: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите длину второй стороны: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите длину третей стороны: ");
int c = int.Parse(Console.ReadLine()!);

if (isTriangle(a, b, c))
{
    Console.WriteLine("Треугольник существует.");
}
else
{
    Console.WriteLine("Треугольник не существует.");
}