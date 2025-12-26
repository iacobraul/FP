//8. Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga
int n;

n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] tokens = input.Split(' ');

int[] v = new int[n];
for (int i = 0; i < n - 1; i++)
{
    v[i] = int.Parse(tokens[i + 1]);
}
v[n - 1] = int.Parse(tokens[0]);

for (int i = 0; i < n; i++)
{
    Console.Write($"{v[i]} ");
}
