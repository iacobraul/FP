//9. Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare
int n = int.Parse(Console.ReadLine());
bool crescator = true, descrescator = true;
int[] v = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

for (int i = 0; i < n - 1; i++)
{
    if (v[i] < v[i + 1])
        descrescator = false;
    if (v[i] > v[i + 1])
        crescator = false;
}

if(crescator || descrescator)
    Console.WriteLine("Secventa este monotona");
else
    Console.WriteLine("Secventa NU este monotona");