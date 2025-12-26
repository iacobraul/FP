//29. MergeSort. Sortati un vector folosind metoda MergeSort
int n;

n = int.Parse(Console.ReadLine());
string input= Console.ReadLine();
string[] tokens = input.Split(' ');

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}

MergeSort(v, 0, n - 1);

void MergeSort(int[] v, int st, int dr)
{
    if (st < dr)
    {
        int mijloc = st + (dr - st) / 2;
        MergeSort(v, st, mijloc);
        MergeSort(v, mijloc + 1, dr);
        Merge(v, st, mijloc, dr);
    }
}

void Merge(int[] v, int st, int mijloc, int dr)
{
    int n1 = mijloc - st + 1;
    int n2 = dr - mijloc;

    int[] left = new int[n1];
    int[] right = new int[n2];

    for (int a = 0; a < n1; a++)
        left[a] = v[st + a];
    for (int b = 0; b < n2; b++)
        right[b] = v[mijloc + 1 + b];

    int i = 0, j = 0;
    int k = st;
    while (i < n1 && j < n2)
    {
        if (left[i] <= right[j])
        {
            v[k] = left[i];
            i++;
        }
        else
        {
            v[k] = right[j];
            j++;
        }
        k++;
    }
    while (i < n1)
    {
        v[k] = left[i];
        i++;
        k++;
    }
    while (j < n2)
    {
        v[k] = right[j];
        j++;
        k++;
    }
}

for (int i = 0; i < n; i++)
{
    Console.Write($"{v[i]} ");
}