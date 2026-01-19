//6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare
int n = int.Parse(Console.ReadLine());
int[] v = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

bool crescator = true;
for(int i =0; i < n - 1; i++)
{
    if (v[i] > v[i + 1])
    {
        crescator = false;
        break;
    }
}

if (crescator)
    Console.WriteLine("DA");
else
    Console.WriteLine("NU");