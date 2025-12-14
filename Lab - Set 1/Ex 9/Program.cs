//9. Afisati toti divizorii numarului n.
int n;

n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n/2; i++)
{
    if (n % i == 0)
    {
        Console.Write($"{i} ");
    }
}
Console.WriteLine(n);
