namespace SortingAlgorithms;
using System;
using System.Collections.Generic;
public class RadixSort : ISortStrategy
{
    public void Sort(int[] arr)
    {
        int maxDigitCount = GetMaxDigitCount(arr);

        for (int digit = 0; digit < maxDigitCount; digit++)
        {
            CountingSort(arr, digit);
        }
    }
    private void CountingSort(int[] arr, int digit)
    {
        const int Radix = 10; // Base 10 for decimal numbers
        List<int>[] buckets = new List<int>[Radix];

        for (int i = 0; i < Radix; i++)
        {
            buckets[i] = new List<int>();
        }

        foreach (int num in arr)
        {
            int digitValue = GetDigitValue(num, digit);
            buckets[digitValue].Add(num);
        }

        int index = 0;
        foreach (List<int> bucket in buckets)
        {
            foreach (int num in bucket)
            {
                arr[index++] = num;
            }
        }
    }

    private int GetMaxDigitCount(int[] arr)
    {
        int maxDigitCount = 0;

        foreach (int num in arr)
        {
            int digitCount = GetDigitCount(num);
            if (digitCount > maxDigitCount)
            {
                maxDigitCount = digitCount;
            }
        }

        return maxDigitCount;
    }

    private int GetDigitCount(int num)
    {
        if (num == 0)
        {
            return 1;
        }

        int count = 0;
        while (num != 0)
        {
            num /= 10;
            count++;
        }
        return count;
    }
    private int GetDigitValue(int num, int digit)
    {
        int divisor = (int)Math.Pow(10, digit);
        return (num / divisor) % 10;
    }
}
