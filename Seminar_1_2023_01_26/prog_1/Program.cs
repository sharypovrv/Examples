// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int sqr = number * number;
double sqr2 = Math.Pow(number, 2);
Console.WriteLine($"Квадрат {number} равен {sqr}");
Console.WriteLine($"Квадрат {number} равен {sqr2}");