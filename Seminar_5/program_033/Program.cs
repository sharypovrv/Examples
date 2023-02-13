// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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

bool isThereNumber(int[] array, int number)
{
    foreach (int el in array)
    {
        if (el == number) return true;
    }

    return false;
}

int[] array = getArray(4, -9, 9);
Console.WriteLine(string.Join(", ", array));

Console.Write("Введите число: ");
int findNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine(isThereNumber(array, findNumber) == true ? "Да" : "Нет");