// Примечание: Сделать каждое действие в отдельной функции

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}

int[] EnterArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Prompt("Введите число: ");
    }
    return array;
}

int CountPositive(int[] array)
{
    int countPositive = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) countPositive++;
    }

    return countPositive;
}

Console.Clear();
int n = Prompt("Введите количество чисел: ");
int[] array = EnterArray(n);
Console.WriteLine($"Количество положительных чисел равно {CountPositive(array)}.");



