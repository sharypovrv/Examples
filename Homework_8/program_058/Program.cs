// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];

//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }

//     return result;
// }

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

int[,] MultiArray(int[,] ar1, int[,] ar2)
{
    int[,] result = new int[ar1.GetLength(0), ar2.GetLength(1)];

    for (int row = 0; row < result.GetLength(0); row++)
    {
        for (int col = 0; col < result.GetLength(1); col++)
        {
            for (int n = 0; n < ar1.GetLength(1); n++)
            {
                result[row, col] += ar1[row, n] * ar2[n, col];
            }
        }
    }

    return result;
}

Console.Clear();
int[,] firstArray = new int[3, 3] { { 2, -1, 3 }, { 4, 2, 0 }, { -1, 1, 1 } };
PrintArray(firstArray);

Console.WriteLine();
int[,] seconArray = new int[3, 1] { { 1 }, { 2 }, { -1 } };
PrintArray(seconArray);

Console.WriteLine();

if (firstArray.GetLength(1) == seconArray.GetLength(0)) PrintArray(MultiArray(firstArray, seconArray));
else Console.WriteLine("Матрицы нельзя умножить.");
