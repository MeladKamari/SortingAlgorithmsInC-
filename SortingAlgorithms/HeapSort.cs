namespace SortingAlgorithms;

public class HeapSort : ISortStrategy
{
    public void Sort(int[] arr)
    {
        int n = arr.Length;

        for (int i = n / 2 - 1; i >= 0; i--)
            Heapify(arr, n, i);

        for (int i = n - 1; i > 0; i--)
        {
            (arr[0], arr[i]) = (arr[i], arr[0]);

            Heapify(arr, i, 0);
        }
    }

    private void Heapify(int[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1; 
        int right = 2 * i + 2; 
        if (left < n && arr[left].CompareTo(arr[largest]) > 0)
            largest = left;
        if (right < n && arr[right].CompareTo(arr[largest]) > 0)
            largest = right;
        if (largest != i)
        {
            (arr[i], arr[largest]) = (arr[largest], arr[i]);
            Heapify(arr, n, largest);
        }
    }
}