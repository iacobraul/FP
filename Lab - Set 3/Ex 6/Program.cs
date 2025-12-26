//6. Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k
int n, k;

n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] tokens = input.Split(' ');
k = int.Parse(Console.ReadLine());

int[] v = new int[n - 1];
for (int i = 0; i < k; i++)
{
    v[i] = int.Parse(tokens[i]);
}
for (int i = k; i < n - 1; i++)
{
    v[i] = int.Parse(tokens[i + 1]);
}

for (int i = 0; i < n - 1; i++)
{
    Console.Write($"{v[i]} ");
}
