//21. Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar)
int[] v1 = { 1, 2, 3, 4, 7 };
int[] v2 = { 1, 2, 3, 4 };
int n1 = v1.Length;
int n2 = v2.Length;

int n = Math.Min(n1, n2);
for( int i = 0; i < n; i++)
{
    if (v1[i] < v2[i])
    {
        Console.WriteLine($"Vectorul 1 este inaintea vectorului 2");
        return;
    }
    else if (v2[i] < v1[i])
    {
        Console.WriteLine($"Vectorul 2 este inaintea vectorului 1");
        return;
    }    
}

if (n1 < n2)
{
    Console.WriteLine($"Vectorul 1 este inaintea vectorului 2");
}
else if (n2 < n1)
{
    Console.WriteLine($"Vectorul 2 este inaintea vectorului 1");
}
else
{
    Console.WriteLine("Vectorii sunt egali");
}
