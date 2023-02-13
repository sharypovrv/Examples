// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string ToBinary(int number)
{
    string result = string.Empty;
    while(number != 0)
    {
        result = (number % 2).ToString() + result;
        number /= 2;
    }
    return result;
}

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(ToBinary(number));