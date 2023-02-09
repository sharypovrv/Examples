// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int GetCountEven(int[] array)
{
    int countEven = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0) countEven++;
    }
    return countEven;
}

Console.Write("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size, 100, 999);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Количество четных чисел равно {GetCountEven(array)}.");