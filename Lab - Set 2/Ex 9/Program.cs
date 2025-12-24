//9. Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.
int n;

n = int.Parse(Console.ReadLine());
int[] v = new int[n];

for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(Console.ReadLine());
}

bool Crescator = true;
bool Descrescator = true;

for (int i = 1; i < n; i++)
{
    if (v[i] > v[i - 1])
    {
        Descrescator = false;
    }
    else if (v[i] < v[i - 1])
    {
        Crescator = false;
    }
}

if (Crescator || Descrescator)
{
    Console.WriteLine("Secventa este monotona.");
}
else
{
    Console.WriteLine("Secventa nu este monotona.");
}