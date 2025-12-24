//11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere
int n, s = 0, inv = 0;

n = int.Parse(Console.ReadLine());
int[] v = new int[n];

for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    inv = 0;
    int c = v[i];
    while (c != 0)
    {
        inv = inv * 10 + c % 10;
        c = c / 10;
    }
    s = s + inv;
}

Console.WriteLine(s);