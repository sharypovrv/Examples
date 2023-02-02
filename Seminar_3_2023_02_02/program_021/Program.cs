// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.
// ● A (3,6); B (2,1) -> 5,09
// ● A (7,-5); B (1,-1) -> 7,21

Console.Clear();

Console.Write("Введи координату X точки A: ");
int xA = int.Parse(Console.ReadLine()!);
Console.Write("Введи координату Y точки A: ");
int yA = int.Parse(Console.ReadLine()!);
Console.Write("Введи координату X точки B: ");
int xB = int.Parse(Console.ReadLine()!);
Console.Write("Введи координату Y точки B: ");
int yB = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2));
// distance = Math.Round(distance, 2);

Console.WriteLine($"{distance:f2}");