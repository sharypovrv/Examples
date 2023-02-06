// Задача “со звездочкой”: Напишите функцию, которая
// принимает одно число - высоту елочки и рисует ее в
// консоли звездочками.

void printHerringborn(int number)
{
    int line = number * 2 - 1;
    for (int i = 1; i <= number; i++)
    {
        for (int j = 1; j <= line; j++)
        {
            if (j > (number - i) && j < (number + i))
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }

        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

printHerringborn(num);