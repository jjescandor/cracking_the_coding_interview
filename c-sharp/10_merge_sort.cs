using System;
using System.Linq;
class Program
{
    public static void Main(string[] args)
    {
        int[] unsorted = { 4, 5, 1, 2, 3, 0, 6 };
        MergeSort(unsorted);
    }
    public static int[] MergeSort(int[] arr)
    {
        int n = arr.Length;
        if (n > 1)
        {
            int mid = arr.Length / 2;
            var left = arr.Take(mid);
            foreach (var num in left)
            {
                Console.WriteLine(num);
            }
        }
        return arr;
    }
    public static T[] ArrayFromRange<T>(T[] originalArray, int startIndex, int length)
    {
        int actualLength = Math.Min(length, originalArray.Length - startIndex);
        T[] copy = new T[actualLength];
        Array.Copy(originalArray, startIndex, copy, 0, actualLength);
        return copy;
    }
}