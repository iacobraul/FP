//12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
//Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.
//De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. 
int n = int.Parse(Console.ReadLine()), grupuri = 0, c = 0;
int[] v = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
    if (v[i] != 0)
    {
        c++;
    }
    else 
    {
        if (c > 0) grupuri++;
        c = 0;
    }
}

Console.WriteLine(grupuri);