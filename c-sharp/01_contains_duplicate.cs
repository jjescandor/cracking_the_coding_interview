using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine($"Duplicate: {ContainsDuplicate(arr)}");
    }
    public static bool ContainsDuplicate(int[] arr)
    {
        int[] store = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (store.Contains(arr[i]))
            {
                return true;
            }
            else
            {
                store[i] = arr[i];
            }
        }
        return false;
    }
}