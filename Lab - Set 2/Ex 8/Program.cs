//8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
int n;

n = int.Parse(Console.ReadLine());

int Fibonacci(int n)
{
    if (n == 1) return 0;
    if (n == 2) return 1;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

Console.WriteLine(Fibonacci(n));