//3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului
int n, min, max, imin = 0, imax = 0;

n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] tokens = input.Split(' ');

int[] v = new int[n];
min = int.Parse(tokens[0]);
max = int.Parse(tokens[0]);
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
    if (v[i] < min)
    {
        min = v[i];
        imin = i;
    }
    else if (v[i] > max)
    {
        max = v[i];
        imax = i;
    }
}
Console.WriteLine($"Minimul se alfa pe pozitia: {imin}, Maximul se afla pe pozitia: {imax}");
