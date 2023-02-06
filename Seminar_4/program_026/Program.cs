// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();

int CountNumbers(int number)
{
    int count = 0;

    if (number == 0)
        count = 1;
    else
        while (number > 0)
        {
            number = number / 10;
            count++;
        }

    return count;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"{num} -> {CountNumbers(num)}");