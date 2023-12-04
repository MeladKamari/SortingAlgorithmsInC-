namespace SortingAlgorithms;

public class PigeonholeSort : ISortStrategy
{
    public void Sort(int[] arr)
    {
        PigeonholeSortAlgorithm(arr);
    }

    private void PigeonholeSortAlgorithm(int[] arr)
    {
        if (arr == null || arr.Length <= 1)
            return;

        int min = arr[0];
        int max = arr[0];

        foreach (int item in arr)
        {
            if (item.CompareTo(min) < 0)
                min = item;
            if (item.CompareTo(max) > 0)
                max = item;
        }

        dynamic range = (dynamic)max - min;
        int pigeonholeCount = Convert.ToInt32(range) + 1;

        List<int>[] pigeonholes = new List<int>[pigeonholeCount];
        for (int i = 0; i < pigeonholeCount; i++)
        {
            pigeonholes[i] = new List<int>();
        }

        foreach (int item in arr)
        {
            int pigeonholeIndex = Convert.ToInt32((dynamic)item - min);
            pigeonholes[pigeonholeIndex].Add(item);
        }

        int index = 0;
        foreach (List<int> pigeonhole in pigeonholes)
        {
            pigeonhole.Sort();
            foreach (int item in pigeonhole)
            {
                arr[index++] = item;
            }
        }
    }
}