public class ShellSort : SortStrategy
{
    public override void Sort(int[] arr)
    {
        int i, j, pos, temp;
        int n = arr.Length;
        pos = 5;
        while (pos > 0) {
            for (i = 0; i < n; i++) {
                j = i;
                temp = arr[i];
                while ((j >= pos) && (arr[j - pos] > temp)) {
                    arr[j] = arr[j - pos];
                    j = j - pos;
                }
                arr[j] = temp;
            }
            if (pos / 2 != 0)
                pos = pos / 2;
            else if (pos == 1)
                pos = 0;
            else
                pos = 1;
        }
    }
}