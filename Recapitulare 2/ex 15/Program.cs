//15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator.
//De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica
int n = int.Parse(Console.ReadLine());
int[] v = new int[n];
bool bitonica = true;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

for(int i = 0; i < n - 1; i++)
{
    if (v[i] > v[i + 1])
    {
        for(int j = i + 1; j < n - 1; j++)
        {
            if (v[j] < v[j + 1])
            {
                bitonica = false;
            }
        }
    }
}

if(bitonica) Console.WriteLine("Secventa este bitonica");
else Console.WriteLine("Secventa nu este bitonica");