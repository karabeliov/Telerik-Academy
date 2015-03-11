using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Write a program that sorts an array of strings using the Quick sort algorithm.
/// </summary>
class QuickSort
{
    static void Main()
    {
        // Input
        Console.Write("Enter Lenght of Array: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength]; // { 3, 8, 7, 5, 2, 1, 9, 6, 4 };

        Console.WriteLine("Write {0} integer number to Array", arrayLength);
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Enter number: ");
            array[index] = int.Parse(Console.ReadLine());
        }

        // Solution 
        QuickSortMethod(array, 0, array.Length - 1);

        // Output
        Console.WriteLine("Sort Array with Quick sort algorithm: {0}", string.Join(", ", array));
    }

    private static void QuickSortMethod(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(array, left, right);

            if (pivot > 1)
            {
                QuickSortMethod(array, left, pivot - 1); // recursive
            }
            if (pivot + 1 < right)
            {
                QuickSortMethod(array, pivot + 1, right); // recursive
            }
        }
    }

    private static int Partition(int[] array, int left, int right)
    {
        int pivot = array[left];

        while (true)
        {
            while (array[left] < pivot)
            {
                left++;
            }
            while (array[right] > pivot)
            {
                right--;
            }

            if (left < right)
            {
                int temp = array[right];
                array[right] = array[left];
                array[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }
}