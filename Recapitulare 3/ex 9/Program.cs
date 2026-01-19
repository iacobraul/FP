//9. Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.
int n = int.Parse(Console.ReadLine());

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
int[] v = new int[n];
for(int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

int k = int.Parse(Console.ReadLine());
int aux;

for (int i = 0; i < k; i++)
{
    aux = v[0];
    for(int j = 0 ; j < n - 1; j++)
    {
        v[j] = v[j + 1];
    }
    v[n - 1] = aux;
}

for(int i = 0; i < n; i++)
{
    Console.Write($"{v[i]} ");
}