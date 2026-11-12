namespace ConsoleApp.Sortings;

public static class MergeSorts
{
    /// <summary>
    /// Takes the unsorted array and sorts the source array [nlogn].
    /// </summary>
    /// <param name="arr">Unsorted array</param>
    /// <param name="st">starting index</param>
    /// <param name="end">ending index</param>
    public static void MergeSort(int[] arr, int st, int end)
    {
        // When only one element or no emelent left.
        if (st >= end)
            return;

        int mid = (st + end) / 2;

        /* Call recursion only when the sub-array length is greater than 2.
        This avoids most of the single element recusion calls and thus, reduces the call stack */
        if ((end - st) + 1 > 2)
        {
            // Divide
            MergeSort(arr, st, mid);
            MergeSort(arr, mid + 1, end);
        }
        // Merge
        Merge(arr, st, mid, end);
    }
    static void Merge(int[] arr, int st, int mid, int end)
    {
        int i = st, j = mid + 1, k = 0;
        int[] temp = new int[end - st + 1];

        // Two pointer on both halves to find the smaller and put that into the temp array
        while (i <= mid && j <= end)
        {
            if (arr[i] <= arr[j])
            {
                temp[k] = arr[i];
                i++;
            }
            else
            {
                temp[k] = arr[j];
                j++;
            }
            k++;
        }

        // Copy remainig elements from left half
        while (i <= mid)
        {
            temp[k] = arr[i];
            i++;
            k++;
        }
        // Copy remainig elements from right half
        while (j <= end)
        {
            temp[k] = arr[j];
            j++;
            k++;
        }

        // Copy sorted array back into the original array, index st + x is for put the element into their corrent index.
        for (int x = 0; x < temp.Length; x++)
        {
            arr[st + x] = temp[x];
        }
    }

    /// <summary>
    /// Takes the unsroted array and returns a new sorted array. Doesn't change the soruce array [nlogn].
    /// </summary>
    /// <param name="arr">Unsorted array</param>
    /// <returns></returns>
    public static int[] MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
            return arr;

        int mid = arr.Length / 2;

        // Create two slices
        int[] left = arr[..mid];
        int[] right = arr[mid..];

        // Recursively sort both halves
        return Merge(left, right);
    }
    static int[] Merge(int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;
        int[] result = new int[left.Length + right.Length];

        // Two pointer on both halves to find the smaller and put that into the temp array
        while (i < left.Length && j < right.Length)
        {
            if (left[i] < right[j])
            {
                result[k] = left[i];
                i++;
            }
            else
            {
                result[k] = right[j];
                j++;
            }
            k++;
        }

        // Copy remainig elements from left half
        while (i < left.Length)
        {
            result[k] = left[i];
            i++;
            k++;
        }
        // Copy remainig elements from right half
        while (j < right.Length)
        {
            result[k] = right[j];
            j++;
            k++;
        }
        return result;
    }
}
