// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Clear();

int GetSum(int A)
{
    int sum = 0;

    for (int i = 1; i <= A; i++)
    {
        sum += i;
    }

    return sum;
}

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма чисел от 1 до {A} равна {GetSum(A)}.");