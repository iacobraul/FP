//16. O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul).
//Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
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
    {   
        for (int j = i + 1; j < n - 1; j++)
        {
            if (v[j] < v[j + 1])
            {
                c++;
            }
        }
        break;
    }
}
if (v[n - 1] > v[0]) c++;

if (c <= 1) Console.WriteLine("Secventa este bitonica rotita");
else Console.WriteLine("Secventa nu este bitonica rotita");