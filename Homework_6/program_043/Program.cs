// Проверить на параллельность и на полное пересечение прямых

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int Prompt(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

bool CheckParallel(int k1, int k2)
{
    return k1 == k2;
}

bool CheckMatch(int k1, int b1, int k2, int b2)
{
    return k1 == k2 && b1 == b2;
}

double[] IntersectionCoordinates(int k1, int b1, int k2, int b2)
{
    double[] intersectionCoordinates = new double[2];

    intersectionCoordinates[0] = (Convert.ToDouble(b2 - b1)) / (k1 - k2);
    intersectionCoordinates[1] = k1 * intersectionCoordinates[0] + b1;

    return intersectionCoordinates;

}

Console.Clear();

int k1 = Prompt("Введите k1: ");
int b1 = Prompt("Введите b1: ");
int k2 = Prompt("Введите k2: ");
int b2 = Prompt("Введите b2: ");

if (CheckMatch(k1, b1, k2, b2))
{
    Console.WriteLine("Прямые совпадают!");
}
else if (CheckParallel(k1, k2))
{
    Console.WriteLine("Прямые параллельны!");
}
else
{
    Console.WriteLine(string.Join(", ", IntersectionCoordinates(k1, b1, k2, b2)));
}