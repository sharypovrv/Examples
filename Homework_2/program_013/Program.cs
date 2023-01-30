// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number / 100 == 0)
    Console.WriteLine($"У числа {number} нет третьей цифры.");
else
{
    int third = number % 10;
    int temp = number / 10;
    
    while (temp / 100 != 0)
    {
        third = temp % 10;
        temp = temp / 10;
    }
    Console.WriteLine($"У числа {number} третья цифра это {third}.");
}