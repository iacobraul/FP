//1. Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
int n = int.Parse(Console.ReadLine()), s = 0;
int[] v = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
    s = s + v[i];
}

Console.WriteLine(s);

