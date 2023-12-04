public class SelectionArray : SortStrategy
{
    public override void Sort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            var smallestVal = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[smallestVal])
                {
                    smallestVal = j;
                }
            }
            
            (arr[smallestVal], arr[i]) = (arr[i], arr[smallestVal]);
        }
    }
}