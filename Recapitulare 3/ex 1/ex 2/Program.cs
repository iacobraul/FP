//2. Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1
int n = int.Parse(Console.ReadLine()), k = int.Parse(Console.ReadLine()), r = -1;
int[] v = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
for( int i = 0; i < n;i ++)
{
    v[i] = int.Parse(tokens[i]);
    if (v[i] == k && r == -1)
        r = i;
}

Console.WriteLine(r);