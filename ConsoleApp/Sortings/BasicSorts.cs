namespace ConsoleApp.Sortings;

public static class BasicSorts
{
    public static void BubbleSort(int[] arr)
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

    public static void SelectionSort(int[] arr)
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

    public static void InsertionSort(int[] arr)
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
}
