//3. Calculati suma si produsul numerelor de la 1 la n
int n = int.Parse(Console.ReadLine()), s = 0, p = 1;
for(int i = 1; i<=n; i++)
{
    s = s + i;
    p = p * i;
}

Console.WriteLine($"Suma: {s}, Produsul: {p}");
