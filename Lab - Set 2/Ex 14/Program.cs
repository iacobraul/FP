//14.O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. 
int n = int.Parse(Console.ReadLine());

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(Console.ReadLine());
}

int scadere = 0;
int crestere = 0;
for (int i = 0; i < n - 1; i++)
{
    if (v[i] > v[i + 1]) scadere++;
    if(v[i] < v[i + 1]) crestere++;
}
if (v[n - 1] > v[0]) scadere++;
if (v[n - 1] < v[0]) crestere++;

if (scadere <= 1 || crestere <= 1)
    Console.WriteLine("Seceventa este monotona rotita");
else
    Console.WriteLine("Secventa nu este monotona rotita");

