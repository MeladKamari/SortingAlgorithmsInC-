namespace SortingAlgorithms;
public class ShellSort : ISortStrategy
{
    public void Sort(int[] arr)
    {
        ShellSortAlgorithm(arr);
    }
    private void ShellSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int gap = n / 2; gap > 0; gap /= 2)
        {
            for (int i = gap; i < n; i++)
            {
                int temp = arr[i];
                int j;
                for (j = i; j >= gap && arr[j - gap].CompareTo(temp) > 0; j -= gap)
                {
                    arr[j] = arr[j - gap];
                }
                arr[j] = temp;
            }
        }
    }
}