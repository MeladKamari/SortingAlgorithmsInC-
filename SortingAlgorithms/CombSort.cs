namespace SortingAlgorithms;

public class CombSort : ISortStrategy
{
    public void Sort(int[] arr)
    {
        CombSortAlgorithm(arr);
    }
    private void CombSortAlgorithm(int[] arr)
    {
        int gap = arr.Length;
        const double shrinkFactor = 1.3;
        bool sorted = false;

        while (!sorted)
        {
            gap = (int)(gap / shrinkFactor);
            if (gap > 1)
            {
                sorted = false;
            }
            else
            {
                gap = 1;
                sorted = true;
            }
            int i = 0;
            while (i + gap < arr.Length)
            {
                if (arr[i].CompareTo(arr[i + gap]) > 0)
                {
                    (arr[i], arr[i + gap]) = (arr[i + gap], arr[i]);
                    sorted = false;
                }
                i++;
            }
        }
    }
}