//3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului.
//Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz)
string input = Console.ReadLine();
string[] tokens = input.Split(' ');
int[] v = new int[tokens.Length];

for (int i = 0; i < tokens.Length; i++)
{
    v[i] = int.Parse(tokens[i]);
}

int vmin = v[0], vmax = v[0], imin = 0, imax = 0;
for (int i = 1; i < v.Length; i++)
{
    if (v[i] < vmin)
    {
        vmin = v[i];
        imin = i;
    }
    else if (v[i] > vmax)
    {
        vmax = v[i];
        imax = i;
    }
}

Console.WriteLine($"Minim pe pozitia {imin}");
Console.WriteLine($"Maxim pe pozitia {imax}");