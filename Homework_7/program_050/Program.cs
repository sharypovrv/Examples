// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("row = ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array2D = GetArray(rows, columns, -10, 10);
PrintArray(array2D);

Console.Write("Введите первую позицию элемента: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую позицию элемента: ");
int column = int.Parse(Console.ReadLine()!);

if (row > rows || column > columns)
{
    Console.WriteLine("В массиве нет такой позиции.");
}
else
{
    Console.WriteLine(array2D[row, column]);
}