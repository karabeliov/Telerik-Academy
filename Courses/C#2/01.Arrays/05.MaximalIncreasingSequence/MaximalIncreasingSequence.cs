using System;
/// <summary>
/// 
/// Write a program that finds the maximal increasing sequence in an array.
/// Example:
/// input	             |   result
/// 3, 2, 3, 4, 2, 2, 4	 |   2, 3, 4
/// 
/// </summary>
class MaximalIncreasingSequence
{
    static void Main()
    {
        // Input
        Console.Write("Enter Lenght of Array: ");
        int arrLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrLenght];

        Console.WriteLine("Write {0} integer number to Array", arrLenght);
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Enter number: ");
            array[index] = int.Parse(Console.ReadLine());
        }

        // Solution and Output
        //int currentNum, maxNum = array[0];
        //int currentCount, maxCount = 0;

        //for (int i = 0; i < array.Length; )
        //{
        //    currentNum[i];
        //    currentCount = 0;
        //    for (; i < array.Length; i++)
        //    {
        //        if (currentNum != array[i])
        //        {
        //            break;
        //        }
        //        currentCount++;
        //    }

        //    if (maxCount <= currentCount)
        //    {
        //        maxCount = currentCount;
        //    }
        //}

    }
}