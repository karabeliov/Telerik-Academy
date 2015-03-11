using System;
using System.Linq;
/// <summary>
/// 
/// Write a program that finds the most frequent number in an array.
/// Example:
///                 input	                            |     result
/// 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	(13 lenght) |   4 (5 times)
/// 
/// </summary>
class FrequentNumber
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

        // Solution 
        Array.Sort(array);
        int counter = 0;
        int bestCount = 0;
        int bestNumber = 0;
        int currentNumber = array[0];
        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] != currentNumber)
            {
                currentNumber = array[index];
                counter = 1;
            }
            else
            {
                counter++;
                if (bestCount < counter)
                {
                    bestCount = counter;
                    bestNumber = array[index];
                }
            }
        }


        // Output
        Console.WriteLine();
        Console.WriteLine("Most frequent number is {0} and he repeat {1} times!", bestNumber, bestCount);
    }
}