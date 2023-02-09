// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

int[] getArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] getChangeArray(int[] array)
{
    int len = array.Length / 2;
    if (array.Length % 2 != 0) len++;

    int[] changeArray = new int[len];

    for (int i = 0; i < array.Length / 2; i++) changeArray[i] = array[i] * array[array.Length - i - 1];
    if (array.Length % 2 != 0) changeArray[len - 1] = array[len - 1];

    return changeArray;
}

Console.Write("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = getArray(size, 1, 9);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();
Console.WriteLine(string.Join(", ", getChangeArray(array)));