using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        int[] unsorted = { 4, 5, 1, 2, 3, 0, 6 };
        int[] sorted = MergeSort(unsorted);
        Console.WriteLine("Sorted array");
        foreach (int num in sorted)
        {
            Console.WriteLine($"{num}, ");
        }
    }
    public static int[] MergeSort(int[] arr)
    {
        if (arr.Length > 1)
        {
            int mid = arr.Length / 2;
            int[] left = MergeSort(SliceArr(arr, 0, mid));
            int[] right = MergeSort(SliceArr(arr, mid, arr.Length));
            arr = Merge(left, right, arr);
        }
        return arr;
    }

    public static int[] Merge(int[] left, int[] right, int[] arr)
    {
        int i, j, k;
        i = j = k = 0;
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                arr[k] = left[i];
                i++;
            }
            else
            {
                arr[k] = right[j];
                j++;
            }
            k++;
        }
        if (i < left.Length)
        {
            arr = MergeArr(SliceArr(arr, 0, k), SliceArr(left, i, left.Length));
        }
        else
        {
            arr = MergeArr(SliceArr(arr, 0, k), SliceArr(right, j, right.Length));
        }
        return arr;
    }

    public static int[] MergeArr(int[] arrOne, int[] arrTwo)
    {
        int[] mergedArr = new int[arrOne.Length + arrTwo.Length];
        for (int i = 0; i < arrOne.Length; i++)
        {
            mergedArr[i] = arrOne[i];
        }
        int idx = mergedArr.Length - 1;
        int length = arrTwo.Length;
        for (int i = 0; i < arrTwo.Length; i++)
        {
            mergedArr[idx] = arrTwo[i];
            idx++;
        }
        return mergedArr;
    }

    public static int[] SliceArr(int[] arr, int startIndex, int length)
    {
        int[] newArr = new int[length - startIndex];
        for (int i = 0; i < length; i++)
        {
            int idx = i + startIndex;
            if (idx < arr.Length)
            {
                newArr[i] = arr[idx];
            }

        }
        return newArr;
    }
}