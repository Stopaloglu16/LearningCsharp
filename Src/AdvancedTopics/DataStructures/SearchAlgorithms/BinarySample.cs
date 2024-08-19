namespace DataStructures.SearchAlgorithms;

internal class BinarySample
{
    public static int GetSample(int[] array, int target)
    {

        int left = 0, right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return mid; // Return the index of the target

            if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1; // Return -1 if the target is not found

    }
}
