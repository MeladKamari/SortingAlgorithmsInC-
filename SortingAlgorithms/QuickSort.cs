namespace SortingAlgorithms;
public class QuickSort : ISortStrategy
{
    public void Sort(int[] arr)
    {
        QuickSortAlgorithm(arr, 0, arr.Length - 1);
    }

    private void QuickSortAlgorithm(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(arr, low, high);

            QuickSortAlgorithm(arr, low, partitionIndex - 1);
            QuickSortAlgorithm(arr, partitionIndex + 1, high);
        }
    }
    private int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j].CompareTo(pivot) < 0)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
        return i + 1;
    }
}
