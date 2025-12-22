//2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive
int n, x, zero = 0, poz = 0, neg = 0;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

n = int.Parse(tokens[0]);
for (int i = 1; i <= n; i++)
{
    x = int.Parse(tokens[i]);
    if (x == 0)
        zero++;
    else if (x > 0)
        poz++;
    else
        neg++;
}

Console.WriteLine($"Pozitive: {poz}, Negative: {neg}, Zero: {zero}");
