using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// We are given an array of integers and a number S.
/// Write a program to find if there exists a subset of the elements of the array that has a sum S.
/// 
/// Example:
///         input array	     |     S    |    result
/// 2, 1, 2, 4, 3, 5, 2, 6   |     14 	|     yes
/// 
/// </summary>
class SubsetSum
{
    static void Main()
    {
        // Input
        Console.Write("Enter sequence: ");
        string input = Console.ReadLine();
        string[] array = input.Split(new char[] { ',', ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        Console.Write("Enter wanted Sum (S): ");
        int wantedSum = int.Parse(Console.ReadLine());

        // Solution and Output
        bool done = false;
        for (int i = 0; i < (2 << array.Length) - 1 && !done; i++)
        {
            int sum = 0;

            for (int j = 0; j < array.Length && !done; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sum += int.Parse(array[j]);
                }

                if (sum == wantedSum)
                {
                    Console.WriteLine("Yes");
                    done = true;
                }

            }
        }
    }
}