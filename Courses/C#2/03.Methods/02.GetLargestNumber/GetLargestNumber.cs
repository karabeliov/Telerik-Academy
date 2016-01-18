using System;
using System.Linq;
/// <summary>
/// 
/// Write a method GetMax() with two parameters that returns the larger of two integers.
/// Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
/// 
/// </summary>
class GetLargestNumber
{
    static void Main()
    {
        // Input
        Console.Write("Enter how many numbers you want to check: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[] userNumbers = new int[length];

        for (int index = 0; index < length; index++)
        {
            Console.Write("Enter {0} number = ", index + 1);
            userNumbers[index] = int.Parse(Console.ReadLine());
        }

        // Solution
        int largestNumber = GetMax(userNumbers);

        // Output
        Console.WriteLine();
        Console.WriteLine("Largest number is {0}", largestNumber);
    }

    private static int GetMax(int[] userNumbers)
    {
        return userNumbers.Max();
    }
}