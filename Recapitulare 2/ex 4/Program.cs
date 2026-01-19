//4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.
//Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1
int n = int.Parse(Console.ReadLine()), a = int.Parse(Console.ReadLine()), poz = -1;
int[] v  = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for (int i = 0; i < n; i++)
{ 
    v[i] = int.Parse(tokens[i]);
    if (v[i] == a && poz == -1)
        poz = i;
}

Console.WriteLine(poz);