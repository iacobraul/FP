//Quicksort. Sortati un vector folosind metoda QuickSort.

namespace QuickSort
{ 
    class Program
    {
        static void Main()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // pi is partitioning index, arr[pi] is now at right place
                int pi = Partition(arr, low, high);
                // Recursively sort elements before partition and after partition
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // pivot
            int i = (low - 1); // Index of smaller element
            for (int j = low; j < high; j++)
            {
                // If current element is smaller than or equal to pivot
                if (arr[j] <= pivot)
                {
                    i++;
                    // swap arr[i] and arr[j]
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            // swap arr[i + 1] and arr[high] (or pivot)
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;
            return i + 1;
        }
    }
}
