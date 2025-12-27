//12. Sortare selectie. Implementati algoritmul de sortare <Selection Sort>
int n;

string input = Console.ReadLine();
string[] tokens = input.Split(' ');
n = tokens.Length;

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

for (int i = 0; i < n - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (v[j] < v[minIndex])
        {
            minIndex = j;
        }
    }
    int temp = v[i];
    v[i] = v[minIndex];
    v[minIndex] = temp;
}

for (int i = 0; i < n; i++)
{
    Console.Write($"{v[i]} ");
}