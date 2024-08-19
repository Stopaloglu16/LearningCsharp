namespace DataStructures.SortAlgorithms;

internal class HeapSample
{
    public static void GetSample(int[] array)
    {
        int n = array.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(array, n, i);
            Utility.PrintArray("First Heap", array);
        }

        for (int i = n - 1; i > 0; i--)
        {
            int temp = array[0];
            array[0] = array[i];
            array[i] = temp;

            Heapify(array, i, 0);
            Utility.PrintArray("Second Heap", array);
        }
    }

    private static void Heapify(int[] array, int n, int i)
    {
        Console.WriteLine("Heapify largest " + i);

        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < n && array[left] > array[largest])
            largest = left;

        if (right < n && array[right] > array[largest])
            largest = right;

        if (largest != i)
        {
            int swap = array[i];
            array[i] = array[largest];
            array[largest] = swap;

            Heapify(array, n, largest);
        }
    }

}
