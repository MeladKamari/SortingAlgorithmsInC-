namespace SortingAlgorithms;

public class MergeSort : ISortStrategy
{
      public void Sort(int[] arr)
      {
          MergeSortAlgorithm(arr, 0, arr.Length - 1);
      }
      private void MergeSortAlgorithm(int[] arr, int left, int right)
      {
          if (left < right)
          {
              int middle = (left + right) / 2;
  
              MergeSortAlgorithm(arr, left, middle);
              MergeSortAlgorithm(arr, middle + 1, right);
  
              Merge(arr, left, middle, right);
          }
      }
      private void Merge(int[] items, int left, int middle, int right)
      {
          int n1 = middle - left + 1;
          int n2 = right - middle;
  
          int[] leftArray = new int[n1];
          int[] rightArray = new int[n2];
  
          for (int i = 0; i < n1; ++i)
          {
              leftArray[i] = items[left + i];
          }
          for (int j = 0; j < n2; ++j)
          {
              rightArray[j] = items[middle + 1 + j];
          }
  
          int iLeft = 0, iRight = 0;
          int k = left;
  
          while (iLeft < n1 && iRight < n2)
          {
              if (leftArray[iLeft].CompareTo(rightArray[iRight]) <= 0)
              {
                  items[k] = leftArray[iLeft];
                  iLeft++;
              }
              else
              {
                  items[k] = rightArray[iRight];
                  iRight++;
              }
              k++;
          }
  
          while (iLeft < n1)
          {
              items[k] = leftArray[iLeft];
              iLeft++;
              k++;
          }
  
          while (iRight < n2)
          {
              items[k] = rightArray[iRight];
              iRight++;
              k++;
          }
      }
}