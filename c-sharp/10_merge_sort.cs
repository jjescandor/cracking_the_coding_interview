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
        int n = arr.Length;
        if (n > 1)
        {
            int mid = arr.Length / 2;
            int[] left = SliceArr(arr, 0, mid);
            int[] right = SliceArr(arr, mid, arr.Length);
            left = MergeSort(left);
            right = MergeSort(right);
            arr = Merge(left, right, arr);
        }
        return arr;
    }

    public static int[] Merge(int[] left, int[] right, int[] arr)
    {
        return arr;
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