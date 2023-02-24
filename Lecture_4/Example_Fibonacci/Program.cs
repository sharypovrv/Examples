int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

Console.Clear();

for (int i = 1; i < 30; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}