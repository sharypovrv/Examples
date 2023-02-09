// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int GetSumOddPosition(int[] array)
{
    int sumOddPosition = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sumOddPosition += array[i];
    }

    // for (int i = 1; i < array.Length; i = i + 2)
    // {
    //     sumOddPosition += array[i];
    // }
    
    return sumOddPosition;
}

Console.Write("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size, -19, 19);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {GetSumOddPosition(array)}.");