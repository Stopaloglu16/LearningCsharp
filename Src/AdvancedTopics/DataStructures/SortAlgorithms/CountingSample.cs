namespace DataStructures.SortAlgorithms;

internal class CountingSample
{
    public static void GetSample(int[] array)
    {
        int max = array.Max();
        int[] count = new int[max + 1];
        int[] output = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
            count[array[i]]++;

        Utility.PrintArray("Count ", count);

        for (int i = 1; i <= max; i++)
            count[i] += count[i - 1];

        Utility.PrintArray("Count ", count);

        for (int i = array.Length - 1; i >= 0; i--)
        {
            output[count[array[i]] - 1] = array[i];
            count[array[i]]--;
        }

        Utility.PrintArray("Count ", count);
        Utility.PrintArray("Output ", output);

        for (int i = 0; i < array.Length; i++)
            array[i] = output[i];
    }

}
