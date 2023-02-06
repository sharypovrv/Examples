// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Multi(int number)
{
    int multi = 1;

    for (int i = 1; i <= number; i++)
    {
        multi *= i;
    }

    return multi;
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{num} -> {Multi(num)}");