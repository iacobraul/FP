//11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere
int n = int.Parse(Console.ReadLine()), s = 0;
int[] v = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
    int inv = 0;
    while (v[i] > 0)
    {
        inv = inv * 10 + v[i] % 10;
        v[i] /= 10;
    }
    s += inv;
}

Console.WriteLine(s);