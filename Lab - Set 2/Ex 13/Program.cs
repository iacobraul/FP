//13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita
int n = int.Parse(Console.ReadLine());

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(Console.ReadLine());
}

int schimbare = 0;
for (int i = 0; i < n-1; i++)
{
    if (v[i] > v[i + 1]) schimbare++;
}
if (v[n - 1] > v[0]) schimbare++;

if (schimbare == 0 || schimbare == 1)
    Console.WriteLine("Seceventa este crescatoare rotita");
else
    Console.WriteLine("Secventa nu este crescatoare rotita");
