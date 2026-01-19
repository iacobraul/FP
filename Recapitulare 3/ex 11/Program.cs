//11. Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene)
int n = int.Parse(Console.ReadLine());
bool[] v = new bool[n + 1];

for (int i = 0; i <= n; i++) v[i] = true;
if (n >= 0) v[0] = false;
if (n >= 1) v[1] = false;

for( int p = 2; p * p < n; p++)
{
    if (v[p] == true)
    {
        for (int i = p * p; i <= n; i = i + p)
            v[i] = false;
    }
}

for (int i = 0; i <= n; i++)
    if (v[i] == true) Console.Write($"{i} ");