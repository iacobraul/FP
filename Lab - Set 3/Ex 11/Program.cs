//11. Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n
int n;
n = int.Parse(Console.ReadLine());

for (int i = 2; i <= n; i++)
{
    if (nrPrim(i))
    {
        Console.Write($"{i} ");
    }
}

bool nrPrim(int x)
{
    for (int i = 2; i*i <= x; i++)
    {
        if (x % i == 0)
           {
              return false;
           }
    }
    return true;
}
