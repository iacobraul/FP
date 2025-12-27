//14. Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 
int n, pozNenul = 0;

string input= Console.ReadLine();
string[] tokens = input.Split(' ');
n = tokens.Length;

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

for (int i = 0; i < n; i++)
{
    if (v[i] != 0)
    {
        (v[i], v[pozNenul])=(v[pozNenul], v[i]);
        pozNenul++;
    }
}

for (int i = 0; i < n; i++)
{
    Console.Write($"{v[i]} ");
}
