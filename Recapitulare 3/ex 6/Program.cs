//6. Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k.
//Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga
int n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] tokens = input.Split(' ');
int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}
int k = int.Parse(Console.ReadLine());

for( int i = k; i < n - 1; i++)
{
    v[i] = v[i + 1];
}

n--;
for (int i = 0; i < n; i++)
{
    Console.Write($"{v[i]} ");
}