namespace SortingAlgorithms;

public class BucketSort : ISortStrategy
{
    public void Sort(int[] items)
    {
        BucketSortAlgorithm(items);
    }
    private void BucketSortAlgorithm(int[] items)
    {
        if (items == null || items.Length <= 1)
            return;
        int minValue = items.Min();
        int maxValue = items.Max();
        dynamic range = (dynamic)maxValue - (dynamic)minValue;
        int bucketCount = Math.Max(1, Convert.ToInt32(range) + 1);
        List<List<int>> buckets = new List<List<int>>(bucketCount);
        for (int i = 0; i < bucketCount; i++)
        {
            buckets.Add(new List<int>());
        }
        foreach (int item in items)
        {
            int bucketIndex = Convert.ToInt32((dynamic)item - minValue) * (bucketCount - 1) / Convert.ToInt32(range);
            buckets[bucketIndex].Add(item);
        }
        int index = 0;
        foreach (var bucket in buckets)
        {
            var bucketArray = bucket.OrderBy(x => x).ToList();
            for (int i = 0; i < bucketArray.Count; i++)
            {
                items[index++] = bucketArray[i];
            }
        }
    }
}