//MergeSort. Sortati un vector folosind metoda MergeSort.
namespace MergeSort
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            MergeSort(arr, 0, arr.Length - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        }

        static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int mid = left + (right - left) / 2;
                // Sort first and second halves
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                // Merge the sorted halves
                Merge(arr, left, mid, right);
            }
        }

        static void Merge(int[] arr, int left, int mid, int right)
        {
            // Find sizes of two subarrays to be merged
            int n1 = mid - left + 1;
            int n2 = right - mid;
            // Create temp arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            // Copy data to temp arrays L[] and R[]
            for (int i = 0; i < n1; i++)
                L[i] = arr[left + i];
            for (int j = 0; j < n2; j++)
                R[j] = arr[mid + 1 + j];
            // Merge the temp arrays back into arr[l..r]
            int k = left; // Initial index of merged subarray
            int ii = 0, jj = 0;
            while (ii < n1 && jj < n2)
            {
                if (L[ii] <= R[jj])
                {
                    arr[k] = L[ii];
                    ii++;
                }
                else
                {
                    arr[k] = R[jj];
                    jj++;
                }
                k++;
            }
            // Copy remaining elements of L[] if any
            while (ii < n1)
            {
                arr[k] = L[ii];
                ii++;
                k++;
            }
            // Copy remaining elements of R[] if any
            while (jj < n2)
            {
                arr[k] = R[jj];
                jj++;
                k++;
            }
        }
    }
}