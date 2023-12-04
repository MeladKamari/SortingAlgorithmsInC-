namespace SortingAlgorithms;

public class BubbleSort : ISortStrategy
{
    public  void Sort(int[] arr)
    {
        bool swapRequired;
        for (var write = 0; write < arr.Length-1; write++) {
            swapRequired = false;
            for (var sort = 0; sort < arr.Length -write - 1; sort++)
            {
                if (arr[sort] > arr[sort + 1])
                {
                    (arr[sort + 1], arr[sort]) = (arr[sort], arr[sort + 1]);
                    swapRequired = true;
                }

                foreach (var item in arr)
                {
                    if (arr[sort]==item)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(item+" ");
                    }
                    else if (arr[sort+1]==item)
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.Write(item+" "); 
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(item+" ");
                    }
                }
                Console.WriteLine();
            }
            if (swapRequired == false)
                break;
        }
    }
}