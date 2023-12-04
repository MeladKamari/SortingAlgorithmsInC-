public class SortedList
{
    private int[] _arr = new int[20];
    private SortStrategy _sortStrategy;
    public void SetSortStrategy(SortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }
    public void Add(int [] arr)
    {
        _arr = arr;
    }
    public void Sort()
    {
        _sortStrategy.Sort(_arr);
        foreach (var item in _arr)
        {
            Console.WriteLine(item.ToString());
        }
        Console.WriteLine();
    }
    
}
