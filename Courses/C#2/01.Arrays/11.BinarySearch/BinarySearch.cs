using System;
/// <summary>
/// 
/// Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
/// 
/// </summary>
class BinarySearch
{
    static void Main()
    {
        // Input
        Console.Write("Enter Lenght of Array: ");
        int arrayLength = int.Parse(Console.ReadLine());  // lenght  array 
        int[] array = new int[arrayLength];

        Console.WriteLine("Write {0} integer number to Array", arrayLength);
        for (int index = 0; index < array.Length; index++) // input N number in array
        {
            Console.Write("Enter number: ");
            array[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter element of Array: ");
        int givenElement = int.Parse(Console.ReadLine());

        // Solution and Output
        Array.Sort(array);
        Console.WriteLine();
        var ind = Array.BinarySearch(array, givenElement); // use method BinarySearch to find the index of given number
        if (ind >= 0 )
        {
            Console.WriteLine("Index of {0} is: {1}", givenElement, ind); 
        }
        else
        {
            Console.WriteLine("{0} is not found!", givenElement); 
        }
    }
}