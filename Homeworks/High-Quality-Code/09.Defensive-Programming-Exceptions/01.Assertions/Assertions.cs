using System;
using System.Linq;
using System.Diagnostics;

class AssertionsHomework
{
    public static T[] SelectionSort<T>(T[] arr) where T : IComparable<T>
    {

        Debug.Assert(arr.Length > 1, "Length of array must be greater then 1!");

        T[] array = new T[arr.Length];
        Array.Copy(arr, array, arr.Length);

        for (int index = 0; index < array.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(array, index, array.Length - 1);
            Swap(ref array[index], ref array[minElementIndex]);
        }

        return array;
    }
  
    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static string BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static string BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex) 
        where T : IComparable<T>
    {
        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return value + " found in " + midIndex + " index ";
            }
            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else 
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return value + " not found";
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        int[] sortedArray = SelectionSort(arr);

        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        Console.WriteLine("sorted = [{0}]", string.Join(", ", sortedArray));

        Console.WriteLine();
        int[] array = SelectionSort(new int[0]);
        int[] array1 = SelectionSort(new int[1]);
        Console.WriteLine("arr = [{0}]", string.Join(", ", array));
        Console.WriteLine("arr = [{0}]", string.Join(", ", array1));

        Console.WriteLine();
        Console.WriteLine(BinarySearch(sortedArray, -1000));
        Console.WriteLine(BinarySearch(sortedArray, 0));
        Console.WriteLine(BinarySearch(sortedArray, 17));
        Console.WriteLine(BinarySearch(sortedArray, 10));
        Console.WriteLine(BinarySearch(sortedArray, 1000));
    }
}
