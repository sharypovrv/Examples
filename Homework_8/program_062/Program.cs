// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

void FillArray(int[,] inArray)
{
    int count = 1;
    int length = inArray.GetLength(0);
    int row = 0;
    int col = 0;

    while (count < length * length)
    {
        while (col + 1 < length && inArray[row, col + 1] == 0)
        {
            inArray[row, col++] = count++;
        }
        while (row + 1 < length && inArray[row + 1, col] == 0)
        {
            inArray[row++, col] = count++;
        }
        while (col - 1 >= 0 && inArray[row, col - 1] == 0)
        {
            inArray[row, col--] = count++;
        }
        while (row - 1 >= 0 && inArray[row - 1, col] == 0)
        {
            inArray[row--, col] = count++;
        }
    }
    inArray[row, col] = count;

}

Console.Clear();
System.Console.Write("Введите размер квадратного массива: ");
int length = int.Parse(Console.ReadLine()!);

int[,] array = new int[length, length];
PrintArray(array);

System.Console.WriteLine();
FillArray(array);
PrintArray(array);
