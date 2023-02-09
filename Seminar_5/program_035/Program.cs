// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

int countElement(int[] array, int minValue, int maxValue)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el >= 10 && el <= 99) count++;
    }
    return count;
}

int[] array = getArray(10, 0, 200);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine();

Console.WriteLine(countElement(array, 10, 99));