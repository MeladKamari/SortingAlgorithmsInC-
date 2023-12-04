namespace SortingAlgorithms;

public class CountingSort : ISortStrategy
{
    public void Sort(int[] arr)
    {
        CountingSortAlgorithm(arr);
    }
    private void CountingSortAlgorithm(int[] arr)
    {
        if (arr.Length == 0)
            return;

        int min = arr[0], max = arr[0];
        foreach (var item in arr)
        {
            if (item.CompareTo(min) < 0)
                min = item;
            if (item.CompareTo(max) > 0)
                max = item;
        }

        // Initialize count array
        int range = Convert.ToInt32(max) - Convert.ToInt32(min) + 1;
        int[] count = new int[range];
        for (int i = 0; i < arr.Length; i++)
        {
            count[Convert.ToInt32(arr[i]) - Convert.ToInt32(min)]++;
        }

        // Update count array to store the position of elements
        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }
        int[] sorted = new int[arr.Length];
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            sorted[count[Convert.ToInt32(arr[i]) - Convert.ToInt32(min)] - 1] = arr[i];
            count[Convert.ToInt32(arr[i]) - Convert.ToInt32(min)]--;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = sorted[i];
        }
    }
}