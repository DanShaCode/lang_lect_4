double Factorial (int n)
{
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(40));

for ( int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i} = {Factorial(i)}");
}

Console.WriteLine();

int Sum (int n)
{
    if (n == 0) return 0;
    if (n == 1) return 1;
    return n + Sum(n-2);
}

Console.WriteLine(Sum(3));