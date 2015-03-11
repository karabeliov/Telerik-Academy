using System;
/// <summary>
/// 
/// Write a program, that reads from the console an array of N integers and an integer K, sorts the array and 
/// using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
/// 
/// </summary>
class BinarySearch
{
    static void Main()
    {
        // Input
        Console.Write("Enter size of Array(N): ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Console.Write("Enter (K) number: ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter Array[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        // Solution

        // Sort Array
        Array.Sort(array);

        while (Array.BinarySearch(array, k) < 0)
        {
            k--;

            if (k < 0) // can't find number
            {
                break;
            }
        }

        // Output
        Console.WriteLine();
        if (k < 0)
        {
            Console.WriteLine("Can't find number!!");
            return;
        }

        Console.WriteLine("Largest number in the array which is less or equal to K is " + k);
    }
}