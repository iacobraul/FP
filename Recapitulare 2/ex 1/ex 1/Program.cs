//1.Se da o secventa de n numere. Sa se determine cate din ele sunt pare
int n = int.Parse(Console.ReadLine()), c = 0;
int[] v = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
    if (v[i] % 2 == 0)
    {
        c++;
    }
}

Console.WriteLine(c);