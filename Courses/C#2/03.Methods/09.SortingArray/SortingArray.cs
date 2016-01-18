using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// 
/// Write a method that return the maximal element in a portion of array of integers starting at given index.
/// Using it write another method that sorts an array in ascending / descending order.
/// 
/// </summary>
class SortingArray
{
    static void Main()
    {
        // Input
        Console.Write("Enter Length of Array: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[] numbers = new int[length];

        for (int index = 0; index < numbers.Length; index++)
        {
            Console.Write("Enter number in the index[{0}]: ", index);
            numbers[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter starting position: ");
        int position = int.Parse(Console.ReadLine());

        if (position < 0 || position >= numbers.Length) // check input
        {
            Console.WriteLine("Invalid position!!!");
            return;
        }
        // Solution
        int[] cutArray = CutArray(numbers, position); // cut Array from start position to End of Array
        int max = cutArray.Max(); // find Max in cutArray

        var ascending = cutArray.OrderBy(num => num); // Sort Ascending
        var descending = cutArray.OrderByDescending(num => num); // Sort Descending

        // Output
        Console.WriteLine();
        Console.WriteLine("Max element in range index[{0}] to index[{1}] is {2}", position, numbers.Length, max);
        Console.WriteLine();
        Console.WriteLine("Sorted Array by Ascending: {0}", string.Join(", ", ascending));
        Console.WriteLine();
        Console.WriteLine("Sorted Array by Descending: {0}", string.Join(", ", descending));
    }

    private static int[] CutArray(int[] numbers, int position)
    {
        List<int> list = new List<int>();
        
        for (int index = position; index < numbers.Length; index++)
        {
            list.Add(numbers[index]);
        }

        return list.ToArray();
    }
}