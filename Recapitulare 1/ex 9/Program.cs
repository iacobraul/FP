//9. Afisati toti divizorii numarului n
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    if (n % i == 0)
    {
        Console.Write($"{i}, ");
    }
}
