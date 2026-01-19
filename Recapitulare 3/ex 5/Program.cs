//5. Se da un vector cu n elemente, o valoare e si o pozitie din vector k.
//Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero
int n = int.Parse(Console.ReadLine()); 

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
int[] v = new int[n + 1];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

int x = int.Parse(Console.ReadLine()), k = int.Parse(Console.ReadLine());
for (int i= n; i > k; i--)
{
    v[i] = v[i - 1];
}
v[k] = x;

for(int i = 0; i <= n; i++)
{
    Console.Write($"{v[i]} ");
}