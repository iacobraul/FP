//16. O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.
int n = int.Parse(Console.ReadLine());

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(Console.ReadLine());
}

int schimbariMonotonie = 0;
int monotoniePrecedenta = 0;
int monotonieCurenta = 0;
for (int i = 0; i < n; i++)
{
    int elementCurent = v[i];
    int elementUrmator = v[(i + 1) % n];

    if (elementCurent != elementUrmator)
    {
        if (elementUrmator > elementCurent)
            monotonieCurenta = 1;
        else if (elementUrmator < elementCurent)
            monotonieCurenta = -1;
        else
            monotonieCurenta = 0;

        if (monotoniePrecedenta != 0 && (monotonieCurenta != monotoniePrecedenta))
        {
            schimbariMonotonie++;
        }

        monotoniePrecedenta = monotonieCurenta;
    }
}

if (schimbariMonotonie<= 2)
    Console.WriteLine("Secventa este bitonica rotita");
else
    Console.WriteLine("Secventa nu este bitonica rotita");