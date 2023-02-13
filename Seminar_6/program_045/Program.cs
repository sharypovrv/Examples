// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int[] CloneArray(int[] array)
{
    int[] result = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[i];
    }

    return result;
}

Console.Clear();
int[] array = GetArray(5, -10, 10);
Console.WriteLine(string.Join(", ", array));
int[] clonedArray = CloneArray(array);
Console.WriteLine(string.Join(", ", clonedArray));