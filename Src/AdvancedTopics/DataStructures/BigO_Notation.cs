namespace DataStructures;

internal class BigO_Notation
{
    /// <summary>
    /// n number for examples
    /// </summary>
    const int n = 1000000;

    //O(1)
    /// <summary>
    /// A constant amount of time
    /// </summary>
    public void Complexity1()
    {
        int myN = 5;
    }


    //O(log n) [log 2 base]
    /// <summary>
    /// Binary Search in a sorted array
    /// </summary>
    public void Complexity2()
    {
        int BinarySearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return -1; // Target not found
        }

        int[] sortedArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int index = BinarySearch(sortedArray, 7);
        Console.WriteLine(index); // Output: 6 (if found)

    }


    //O(n)
    /// <summary>
    /// Loop n times
    /// </summary>
    public void Complexity3()
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }


    //O(n log n)
    /// <summary>
    /// Merge Sort Algorithm
    /// </summary>
    public void Complexity4()
    {
        void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];

            Array.Copy(arr, left, L, 0, n1);
            Array.Copy(arr, mid + 1, R, 0, n2);

            int i = 0, j = 0, k = left;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                    arr[k++] = L[i++];
                else
                    arr[k++] = R[j++];
            }

            while (i < n1)
                arr[k++] = L[i++];
            while (j < n2)
                arr[k++] = R[j++];
        }

        void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        int[] array = { 12, 11, 13, 5, 6, 7 };
        MergeSort(array, 0, array.Length - 1);
        Console.WriteLine(string.Join(", ", array)); // Output: 5, 6, 7, 11, 12, 13
    }



    //O(n^2)
    /// <summary>
    /// Bubble Sort Algorithm
    /// </summary>
    public void Complexity5()
    {
        void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j + 1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        BubbleSort(array);
        Console.WriteLine(string.Join(", ", array)); // Output: 11, 12, 22, 25, 34, 64, 90
    }


    //O(2^n)
    /// <summary>
    /// Recursive Fibonacci Calculation
    /// </summary>
    public void Complexity6()
    {
        int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        int fibNumber = Fibonacci(5);
        Console.WriteLine(fibNumber); // Output: 5
    }


    //O(n!)
    /// <summary>
    /// Generating all permutations of a string
    /// </summary>
    public void Complexity7()
    {
        // O(n!) Example: Generating all permutations of a string
        void Permute(char[] arr, int l, int r)
        {
            if (l == r)
                Console.WriteLine(new string(arr));
            else
            {
                for (int i = l; i <= r; i++)
                {
                    Swap(ref arr[l], ref arr[i]);
                    Permute(arr, l + 1, r);
                    Swap(ref arr[l], ref arr[i]); // Backtrack
                }
            }
        }

        void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }

        string str = "ABC";
        Permute(str.ToCharArray(), 0, str.Length - 1);
        // Output:
        // ABC
        // ACB
        // BAC
        // BCA
        // CAB
        // CBA
    }


}
