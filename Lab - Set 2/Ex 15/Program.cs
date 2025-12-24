//15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica
int n = int.Parse(Console.ReadLine());

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(Console.ReadLine());
}

int j = 0;
while (j < n - 2 && v[j] <= v[j + 1])
{
    j++;
}
while (j < n - 1 && v[j] >= v[j + 1])
{
    j++;
}

if(j == n - 1) Console.WriteLine("Secventa este bitonica");
else Console.WriteLine("Secventa nu este bitonica");

