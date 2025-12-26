//28. Quicksort. Sortati un vector folosind metoda QuickSort
int n;

n = int.Parse(Console.ReadLine());
string input= Console.ReadLine();
string[] tokens = input.Split(' ');

int[] v = new int[n];
for (int i = 0; i < n; i++)
{
    v[i] = int.Parse(tokens[i]);
}
QuickSort(v, 0, n - 1);

void QuickSort(int[] v, int low, int high)
{
    if (low < high)
    {
        int pi = Partition(v, low, high);
        QuickSort(v, low, pi - 1);
        QuickSort(v, pi + 1, high);
    }
}

int Partition(int[] v, int low, int high)
{
    int pivot = v[high];
    int i = (low - 1);
    for (int j = low; j < high; j++)
    {
        if (v[j] < pivot)
        {
            i++;
            (v[i], v[j]) = (v[j], v[i]);
        }
    }
    (v[i+ 1], v[high]) = (v[high], v[i + 1]);
    return i + 1;
}

for (int i = 0; i < n; i++)
{
    Console.Write($"{v[i]} ");
}