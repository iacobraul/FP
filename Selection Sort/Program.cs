//Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
namespace SelectionSort
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 64, 25, 12, 22, 11 };
            SelectionSort(arr);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIdx])
                    {
                        minIdx = j;
                    }
                }
                // Swap the found minimum element with the first element
                int temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
