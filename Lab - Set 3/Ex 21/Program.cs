//21. Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar)

string inputS1 = Console.ReadLine();
string[] tokensS1 = inputS1.Split(' ');
string[] s1 = new string[tokensS1.Length];

string inputS2 = Console.ReadLine();
string[] tokensS2 = inputS2.Split(' ');
string[] s2 = new string[tokensS2.Length];

for (int i = 0; i < s1.Length; i++)
{
    s1[i] = tokensS1[i];
}
for (int i = 0; i < s2.Length; i++)
{
    s2[i] = tokensS2[i];
}

int n = Math.Min(s1.Length, s2.Length);

for(int i = 0; i < n; i++)
{
    if (string.Compare(s1[i], s2[i]) < 0)
    {
        Console.WriteLine("Primul vector este primul in ordine lexicografica.");
        return;
    }
    else if (string.Compare(s1[i], s2[i]) > 0)
    {
        Console.WriteLine("Al doilea vector este primul in ordine lexicografica.");
        return;
    }
}

if (s1.Length < s2.Length)
{
    Console.WriteLine("Primul vector este primul in ordine lexicografica.");
}
else if (s1.Length > s2.Length)
{
    Console.WriteLine("Al doilea vector este primul in ordine lexicografica.");
}
else
{
    Console.WriteLine("Vectorii sunt egali.");
}