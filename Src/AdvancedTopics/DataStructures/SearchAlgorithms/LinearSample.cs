namespace DataStructures.SearchAlgorithms;

internal class LinearSample
{

    public static int GetSample(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
                return i; // Return the index of the target
        }

        return -1; // Return -1 if the target is not found
    }
}
