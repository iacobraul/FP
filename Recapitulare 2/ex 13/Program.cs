//13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare
//prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul).
//Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
int n = int.Parse(Console.ReadLine());
int[] v = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

int c = 0;
for (int i = 0; i < n - 1; i++)
{
    if (v[i] > v[i + 1])
        c++;
}
if (v[n - 1] > v[0])
    c++;

if (c <= 1)
    Console.WriteLine("Secventa este crescatoare rotita");
else
    Console.WriteLine("Secventa NU este crescatoare rotita");