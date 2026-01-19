//2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive
int n = int.Parse(Console.ReadLine()), poz = 0, neg = 0, zero = 0;
int[] v = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for(int i =0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
    if (v[i] < 0) neg++;
    else if (v[i] == 0) zero++;
    else poz++;
}

Console.WriteLine($"Negative: {neg}, Zero: {zero}, Pozitive: {poz}");