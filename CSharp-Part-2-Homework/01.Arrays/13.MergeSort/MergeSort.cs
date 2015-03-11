using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 
/// Write a program that sorts an array of integers using the Merge sort algorithm.
/// 
/// </summary>
class MergeSort
{
    static void Main(string[] args)
    {

        // Input
        Console.Write("Enter Lenght of Array: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];

        Console.WriteLine("Write {0} integer number to Array", arrayLength);
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Enter number: ");
            array[index] = int.Parse(Console.ReadLine());
        }

        // Solution 
        MergeSortMethod(array, 0, arrayLength - 1);

        // Output
        Console.WriteLine("Sort Array with Merge sort algorithm: {0}", string.Join(", ", array));
    }

    static public void MergeSortMethod(int[] numbers, int left, int right)
    {
        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            MergeSortMethod(numbers, left, mid); // recursive
            MergeSortMethod(numbers, (mid + 1), right); // recursive

            DoMerge(numbers, left, (mid + 1), right);
        }
    }

    static public void DoMerge(int[] numbers, int left, int mid, int right) 
    {
        int[] temp = new int[25];
        int i, left_end, num_elements, tmp_pos;

        left_end = (mid - 1);
        tmp_pos = left;
        num_elements = (right - left + 1);

        while ((left <= left_end) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[tmp_pos++] = numbers[left++];
            else
                temp[tmp_pos++] = numbers[mid++];
        }

        while (left <= left_end)
            temp[tmp_pos++] = numbers[left++];

        while (mid <= right)
            temp[tmp_pos++] = numbers[mid++];

        for (i = 0; i < num_elements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }
}