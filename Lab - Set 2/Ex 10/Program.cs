//10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa
int n, c = 0, cmax=0;

n = int.Parse(Console.ReadLine());
int[] v = new int[n];

for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(Console.ReadLine());
}

for(int i = 0; i < n; i++)
{   c = 1;
    for(int j = i + 1; j < n; j++)
    {
        if (v[i] == v[j])
        {
            c++;
        }
        else
        {
            break;
        }
    }
    if (c > cmax)
    {
        cmax = c;
    }
}

Console.WriteLine(cmax);