//20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3)
int m, n;
string input = Console.ReadLine();
string[] tokens = input.Split(' ');
m = int.Parse(tokens[0]);
n = int.Parse(tokens[1]);

int parteIntreaga = m / n;
int rest = m % n;
if(rest!=0) Console.Write($"{parteIntreaga}.");
else Console.WriteLine(parteIntreaga);

Dictionary<int, int> Resturi = new Dictionary<int, int>();
List<int> Cifre = new List<int>();
int pozitiePerioada = -1;
int pozitie = 0;

while (rest != 0)
{
    if (Resturi.ContainsKey(rest))
    {
        pozitiePerioada = Resturi[rest];
        break;
    }
    Resturi[rest] = pozitie;
    rest *= 10;
    int cifra = rest / n;
    Cifre.Add(cifra);
    rest = rest % n;
    pozitie++;
}

for (int i = 0; i < Cifre.Count; i++)
{
    if (i == pozitiePerioada)
    {
        Console.Write("(");
    }
    Console.Write(Cifre[i]);
}
if (pozitiePerioada != -1)
{
    Console.Write(")");
}
