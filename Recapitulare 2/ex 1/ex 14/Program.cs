//14. O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive.
//Determinati daca o secventa de n numere este o secventa monotona rotita. 
int n = int.Parse(Console.ReadLine());
int[] v = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

int crescator = 0, descrescator = 0;
for (int i = 0; i < n - 1; i++)
{
    if (v[i] < v[i + 1])
        descrescator++;
    if (v[i] > v[i + 1])
        crescator++;
}
if (v[n - 1] < v[0])
    descrescator++;
if (v[n - 1] > v[0])
    crescator++;

if (crescator <= 1 || descrescator <= 1)
    Console.WriteLine("Secventa este monotona rotita");
else
    Console.WriteLine("Secventa NU este monotona rotita");