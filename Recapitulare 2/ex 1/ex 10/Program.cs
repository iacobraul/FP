//10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa
int n = int.Parse(Console.ReadLine()), c = 0, max = 0;
int[] v = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

for( int i = 0; i < n - 1; i++)
{
    if (v[i] == v[i + 1])
    {
        c++;
        if (c > max) max = c;
    }
    else
    {
        c = 0;
    }
}

Console.WriteLine(max + 1);
