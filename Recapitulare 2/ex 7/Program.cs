//7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa
int n = int.Parse(Console.ReadLine()), max, min;
int[] v = new int[n];

string input = Console.ReadLine();
string[] tokens = input.Split(' ');

for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}
min = v[0];
max = v[0];

for(int i = 0; i < n; i++)
{
    if (v[i] < min)
        min = v[i];
    if (v[i] > max)
        max = v[i];
}
Console.WriteLine($"Minim: {min}, Maxim: {max}");

