using System;
/// <summary>
/// 
/// Write a program that finds in given array of integers a sequence of given sum S (if present).
/// Example:
///         array	       |  S	   |        result
/// 4, 3, 1, 4, 2, 5, 8	   |  11   |       4, 2, 5
/// 
/// </summary>
class FindSumArray
{
    static void Main()
    {
        // Input
        Console.Write("Enter Lenght of Array: ");
        int arrayLength = int.Parse(Console.ReadLine());  // lenght  array 
        int[] array = new int[arrayLength];

        Console.Write("Enter wanted sum: ");
        int wantedSum = int.Parse(Console.ReadLine());

        Console.WriteLine("Write {0} integer number to Array", arrayLength);
        for (int index = 0; index < array.Length; index++) // input N number in array
        {
            Console.Write("Enter number: ");
            array[index] = int.Parse(Console.ReadLine());
        }

        // Solution and Output
        Console.WriteLine();
        int currentSum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j < array.Length; j++)
            {
                currentSum += array[j];

                if (currentSum == wantedSum) // check is current sum is equel to wanted sum
                {
                    Console.Write("The sequence with sum {0} is: ", wantedSum);
                    Console.Write("{");
                    for (int k = i; k <= j; k++) // print sequence
                    {
                        Console.Write(k != j ? array[k] + ", " : array[k] + "}");
                    }
                    Console.WriteLine();
                    return;
                }
            }

            currentSum = 0;
        }

        if (currentSum == 0)
        {
            Console.WriteLine("Not found sequence");
        }       
    }
}