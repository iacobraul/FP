//3. Calculati suma si produsul numerelor de la 1 la n
int n, s = 0, p = 1;

n = int.Parse(Console.ReadLine());

for(int i = 1; i <= n; i++)
    {
    s += i;
    p *= i;
}

Console.WriteLine($"Suma:{s}, Produs:{p}");
