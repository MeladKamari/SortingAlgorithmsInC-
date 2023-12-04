namespace SortingAlgorithms;

public class CycleSort : ISortStrategy
{
    public void Sort(int[] arr)
    {
        CycleSortAlgorithm(arr);
    }
    private void CycleSortAlgorithm(int[] arr)
    {
        int n = arr.Length;
        for (int start = 0; start < n - 1; start++)
        {
            int item = arr[start];
            int pos = start;

            for (int i = start + 1; i < n; i++)
            {
                if (arr[i].CompareTo(item) < 0)
                {
                    pos++;
                }
            }
            if (pos == start)
            {
                continue;
            }
            while (item.CompareTo(arr[pos]) == 0)
            {
                pos++;
            }
            int temp = arr[pos];
            arr[pos] = item;
            item = temp;

            while (pos != start)
            {
                pos = start;
                for (int i = start + 1; i < n; i++)
                {
                    if (arr[i].CompareTo(item) < 0)
                    {
                        pos++;
                    }
                }

                while (item.CompareTo(arr[pos]) == 0)
                {
                    pos++;
                }
                temp = arr[pos];
                arr[pos] = item;
                item = temp;
            }
        }
    }
}