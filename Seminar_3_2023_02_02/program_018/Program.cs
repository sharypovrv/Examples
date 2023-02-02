// Напишите программу, которая по заданному номеру
// четверти, показывает диапазон возможных координат
// точек в этой четверти (x и y).

Console.Clear();

Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine()!);

while (num < 1 || num > 4)
{
    Console.WriteLine("Введите номер четверти от 1 до 4: ");
    num = int.Parse(Console.ReadLine()!);
}

// if (num == 1)
// {
//     Console.WriteLine("X положительный, Y положительный");
// }
// else if (num == 2)
// {
//     Console.WriteLine("X отрицательный, Y положительный");
// }
// else if (num == 3)
// {
//     Console.WriteLine("X отрицательный, Y отрицательный");
// }
// else
// {
//     Console.WriteLine("X положительный, Y отрицательный");
// }

switch (num)
{
    case 1:
        Console.WriteLine("X положительный, Y положительный");
        break;
    case 2:
        Console.WriteLine("X отрицательный, Y положительный");
        break;
    case 3:
        Console.WriteLine("X отрицательный, Y отрицательный");
        break;
    case 4:
        Console.WriteLine("X положительный, Y отрицательный");
        break;
    default:
        break;
}