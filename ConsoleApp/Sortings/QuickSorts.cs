namespace ConsoleApp.Sortings;

public static class QuickSorts
{
    public static void QuickSort(int[] arr, int st, int end)
    {
        if (st >= end)
        {
            return;
        }
        // Get the pivot index after partitioning
        int pivotIdx = Partition(arr, st, end);
        // Again partition for the left side of the pivot
        QuickSort(arr, st, pivotIdx - 1);
        // Again partition for the right side of the pivot
        QuickSort(arr, pivotIdx + 1, end);
    }
    static int Partition(int[] arr, int st, int end)
    {
        // idx for the index where the elements will inserted;
        int idx = st - 1, pivot = arr[end];

        for (int i = st; i < end; i++)
        {
            if (arr[i] <= pivot)
            {
                idx++;
                (arr[idx], arr[i]) = (arr[i], arr[idx]);
            }
        }
        // at the end of the loop swap the pivot with the next position of the left partition.
        idx++;
        (arr[idx], arr[end]) = (arr[end], arr[idx]);
        return idx;

    }
}
