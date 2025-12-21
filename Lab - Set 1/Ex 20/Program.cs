//20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3)
int m, n;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

m = int.Parse(tokens[0]);
n = int.Parse(tokens[1]);

Console.Write(m/n);
if (m % n == 0) return;
else Console.Write(".");

int cifra, rest, parteFract = m % n;
List<int> resturi = new List<int>();
List<int> cifre = new List<int>();

resturi.Add(parteFract);
bool periodic = false;
do
{
    cifra = parteFract * 10 / n;
    cifre.Add(cifra);
    rest = parteFract * 10 % n;

    if (!resturi.Contains(rest))
    {
        resturi.Add(rest);
    }
    else
    {
        periodic = true;
        break;
    }

    parteFract = rest;
} while (rest != 0);

if (!periodic)
{
    foreach (var item in cifre)
    {
        Console.Write(item);
    }
}
else
{
    for (int i = 0; i < resturi.Count; i++)
    {
        if (resturi[i] == rest)
        {
            Console.Write("(");
        }
        Console.Write(cifre[i]);
    }
    Console.WriteLine(")");
}
