//11. Afisati in ordine inversa cifrele unui numar n
int n = int.Parse(Console.ReadLine());
int inv = 0;

while(n > 0)
{
    inv = inv * 10 + n % 10;
    n = n / 10;
}

Console.WriteLine(inv);
