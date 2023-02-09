// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetDoubleArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = minValue + (maxValue - minValue) * new Random().NextDouble();
    }
    return array;
}

void PrintDoubleArray(double[] array)
{
    foreach (double item in array)
    {
        Console.Write($"{item:f2}; ");
    }
}

double findMin(double[] array)
{
    double min = array[0];
    foreach (double item in array)
    {
        if (item < min) min = item;
    }
    return min;
}

double findMax(double[] array)
{
    double max = array[0];
    foreach (double item in array)
    {
        if (item > max) max = item;
    }
    return max;
}

double DiffBetweenMaxMin(double[] array)
{
    return findMax(array) - findMin(array);
}

Console.Write("Введите количество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);

double[] array = GetDoubleArray(size, 0, 99);
PrintDoubleArray(array);
// Console.WriteLine(string.Join(", ", array));

Console.WriteLine();
Console.WriteLine($"Разница между максимальным ({findMax(array):f2}) и минимальным ({findMin(array):f2}) элементов массива равна {DiffBetweenMaxMin(array):f2}.");