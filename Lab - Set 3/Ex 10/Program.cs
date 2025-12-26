//10. Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1
int n, k;
bool gasit = false;

n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] tokens = input.Split(' ');
k = int.Parse(Console.ReadLine());

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

int st = 0;
int dr = n - 1;

while (st <= dr)
{
    int m = (st + dr) / 2;
    if (v[m] == k) 
    { 
        Console.WriteLine(m);
        gasit = true;
        break;
    }
    else if (v[m] < k)
    {
        st = m + 1;
    }
    else
    {
        dr = m;
    }
    
}
if (!gasit)
{
    Console.WriteLine(-1);
}