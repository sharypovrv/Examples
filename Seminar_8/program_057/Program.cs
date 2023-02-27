// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] GetArray1D(int[,] inArray2D)
{
    int[] array1D = new int[inArray2D.GetLength(0) * inArray2D.GetLength(1)];
    int k = 0;
    for (int i = 0; i < inArray2D.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2D.GetLength(1); j++)
        {
            array1D[k++] = inArray2D[i, j];
        }
    }
    return array1D;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int temp = inArray[j];
                inArray[j] = inArray[i];
                inArray[i] = temp;
            }
        }
    }
}

void PrintDictionary(int[,] inArray2D)
{

    int[] inArray = GetArray1D(inArray2D);
    SortArray(inArray);

    int count = 1;
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        if (inArray[i] == inArray[i + 1])
        {
            count += 1;
        }
        else
        {
            Console.WriteLine($"{inArray[i]} встречается {count} раз.");
            count = 1;
        }
    }
    Console.WriteLine($"{inArray[inArray.Length - 1]} встречается {count} раз.");
}

Console.Clear();
Console.Write("row = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col = ");
int col = int.Parse(Console.ReadLine()!);
int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);

Console.WriteLine();
PrintDictionary(array2D);