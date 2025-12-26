//16. Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului
int n, r;

n = int.Parse(Console.ReadLine());
string input= Console.ReadLine();
string[] tokens = input.Split(' ');

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

r = v[0];
for (int i = 1; i < n; i++)
{
    r = cmmmdc(r, v[i]);
}

int cmmmdc(int a, int b)
{
    while (b != 0)
    {
        int r = a % b;
        a = b;
        b = r;
    }
    return a;
}

Console.WriteLine(r);
