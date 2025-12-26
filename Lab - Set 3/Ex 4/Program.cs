//4. Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea
int n, min, max, apMin = 0, apMax = 0;

n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] tokens = input.Split(' ');

int[] v = new int[n];
min = int.Parse(tokens[0]);
max = int.Parse(tokens[0]);
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
    if (v[i] <= min)
    {
        if (v[i] == min)
            apMin++;
        else
        {
            min = v[i];
            apMin = 1;
        }
    }
    else if (v[i] >= max)
    {   
        if (v[i] == max)
            apMax++;
        else
        { 
            max = v[i];
            apMax = 1;
        }
    }
}
Console.WriteLine($"{min}: {apMin} ori; {max}: {apMax} ori;");