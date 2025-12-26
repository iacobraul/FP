//5. Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero
int n, e, k;

n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] tokens = input.Split(' ');

e = int.Parse(Console.ReadLine());
k = int.Parse(Console.ReadLine());

int[] v = new int[n + 1];
for (int i = 0; i < k; i++)
{
    v[i] = int.Parse(tokens[i]);
}
v[k] = e;
for (int i = k + 1; i <= n; i++)
{
    v[i] = int.Parse(tokens[i - 1]);
}

for (int i = 0; i <= n; i++)
{
    Console.Write($"{v[i]} ");
}
