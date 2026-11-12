using ConsoleApp.Sortings;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] x = { 8, 9, 10, 2, 6, 7 };

        //BasicSorts.BubbleSort(x);
        //BasicSorts.SelectionSort(x);
        //BasicSorts.InsertionSort(x);
        MergeSorts.MergeSort(x, 0, x.Length - 1);
        //int[] result = MergeSorts.MergeSort(x);
        //QuickSorts.QuickSort(x, 0, x.Length -1);

        Console.WriteLine(String.Join(", ", x));
        //Console.WriteLine(String.Join(", ", result));
    }
}