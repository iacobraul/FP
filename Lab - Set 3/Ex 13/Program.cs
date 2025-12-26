// 13. Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>
int n;

n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
string[] tokens = input.Split(' ');

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

for (int i = 1; i < n; i++)
{
    int key = v[i];
    int j = i - 1;
    while (j >= 0 && v[j] > key)
    {
        v[j + 1] = v[j];
        j--;
    }
    v[j + 1] = key;
}

for(int i = 0; i < n; i++)
{
    Console.Write($"{v[i]} ");
}