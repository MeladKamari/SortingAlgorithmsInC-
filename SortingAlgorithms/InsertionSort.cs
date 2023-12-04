namespace SortingAlgorithms;

public class InsertionSort():ISortStrategy
{
    public  void Sort(int[] arr)
    {
        for (var i = 1; i < arr.Length; i++)
        {
            var key = arr[i];
            var flag = 0;
            for (var j = i - 1; j >= 0 && flag != 1;)
            {
                if (key < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j--;
                    arr[j + 1] = key;
                }
                else flag = 1;
            }
        }
    }
}