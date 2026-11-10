using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks.Sources;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] x = { 8, 9, 10, 2, 6, 7 };

        //BubbleSort(x);
        //SelectionSort(x);
        //InsertionSort(x);
        //MergeSort(x, 0, x.Length - 1);
        int[] result = MergeSort(x);

        //Console.WriteLine(String.Join(", ", x));
        Console.WriteLine(String.Join(", ", result));
    }

    static void BubbleSort(int[] arr)
    {
        int len = arr.Length;
        for (int i = 0; i < len - 1; i++)
        {
            var swapped = false;

            for (int j = 0; j < len - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapped = true;
                }
            }

            if (!swapped)
            {
                break;
            }
        }
        //return arr;
    }

    static void SelectionSort(int[] arr)
    {
        int len = arr.Length;
        for (int i = 0; i < len - 1; i++)
        {
            var swapped = false;
            var minIndex = i;

            for (int j = i + 1; j < len; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            if (minIndex != i)
            {
                var temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
                swapped = true;
            }

            if (!swapped)
            {
                break;
            }
        }
        //return arr;
    }

    static void InsertionSort(int[] arr)
    {
        int len = arr.Length;
        for (int i = 1; i < len; i++)
        {
            int current = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > current)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = current;
        }
        //return arr;
    }

    static void MergeSort(int[] arr, int st, int end)
    {
        // When only one element or no emelent left.
        if (st >= end)
            return;

        int mid = (st + end)/2;
        // Divide
        MergeSort(arr, st, mid);
        MergeSort(arr, mid+1, end);
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

    static int[] MergeSort(int[] arr)
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