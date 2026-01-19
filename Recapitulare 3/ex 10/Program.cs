//10. Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare.
//Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1
int n = int.Parse(Console.ReadLine());

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
int[] v = new int[n];

for(int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

int k = int.Parse(Console.ReadLine());
int st = 0, dr = n - 1, r = -1;

while(st <= dr)
{
    int mij = (st + dr + 1) / 2;
    if (k == v[mij]) 
    { 
        r = mij;
        break;
    }
    else if (k < v[mij]) dr = mij - 1;
    else st = mij + 1;
}

Console.WriteLine(r);