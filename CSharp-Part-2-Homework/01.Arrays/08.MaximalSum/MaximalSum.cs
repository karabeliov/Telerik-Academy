using System;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// Write a program that finds the sequence of maximal sum in given array.
/// Example:
///              input	              |    result
/// 2, 3, -6, -1, 2, -1, 6, 4, -8, 8  |	 2, -1, 6, 4
/// 
/// Can you do it with only one loop (with single scan through the elements of the array)?
/// 
/// </summary>
class MaximalSum
{
    static void Main()
    {
        // Input
        Console.Write("Enter Lenght of Array: ");
        int arrayLength = int.Parse(Console.ReadLine());  // lenght  array 
        int[] array = new int[arrayLength];

        Console.Write("Enter how many number to sum: ");
        int elementToSum = int.Parse(Console.ReadLine()); // how many number to sum

        Console.WriteLine();
        if (elementToSum > arrayLength) // check input
        {
            Console.WriteLine("Error number to sum is bigger then lenght of array");
            return;
        }

        Console.WriteLine("Write {0} integer number to Array", arrayLength);
        for (int index = 0; index < array.Length; index++) // input N number in array
        {
            Console.Write("Enter number: ");
            array[index] = int.Parse(Console.ReadLine());
        }

        // Solution and Output
        Console.Write("The sum of the {0} largest numbers ( ", elementToSum);
        array = array.OrderByDescending(x => x).ToArray(); // order number
        for (int index = 0; index < elementToSum; index++) // print largest number
        {
            if (index == elementToSum - 1) // remove last coma
            {
                Console.Write("{0} ", array[index]);
            }
            else
            {
                Console.Write("{0}, ", array[index]);
            }
        }

        Console.WriteLine(") is {0}", array.Take(elementToSum).Sum()); // print sum 
    }
}