//7. Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector.
int n;

n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] tokens = input.Split(' ');

int[] v = new int[n+1];
for (int i = 1; i <= n; i++)
{
    v[i] = int.Parse(tokens[n-i]);
}

for (int i = 1; i <= n; i++)
{
    Console.Write($"{v[i]} ");
}