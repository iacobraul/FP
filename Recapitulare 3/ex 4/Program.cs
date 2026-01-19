//4. Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea
string input = Console.ReadLine();
string[] tokens = input.Split(' ');

int[] v = new int[tokens.Length];
int vmin = int.Parse(tokens[0]), vmax = int.Parse(tokens[0]), cntMin = 0, cntMax = 0;

for (int i = 0; i < tokens.Length; i++)
{
    v[i] = int.Parse(tokens[i]);
    if (v[i] <= vmin)
    {
        if (v[i] < vmin)
        {
            cntMin = 1;
            vmin = v[i];
        }
        else
        {
            cntMin++;
        }
    }
    else if(v[i] >= vmax)
    {
        if (v[i] > vmax)
        {
            cntMax = 1;
            vmax = v[i];
        }
        else
        {
            cntMax++;
        }
    }
}

Console.WriteLine($"Minim {vmin} apare de {cntMin} ori");
Console.WriteLine($"Maxim {vmax} apare de {cntMax} ori");
