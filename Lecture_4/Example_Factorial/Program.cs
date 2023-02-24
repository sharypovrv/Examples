double Factorial(double n)
{
    if (n == 1 || n == 0) return 1;
    return n * Factorial(n - 1);
}

Console.Clear();

for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}

