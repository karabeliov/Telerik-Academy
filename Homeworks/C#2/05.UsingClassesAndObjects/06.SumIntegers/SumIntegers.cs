using System;
using System.Linq;
/// <summary>
/// 
/// You are given a sequence of positive integer values written into a string, separated by spaces.
/// Write a function that reads these values from given string and calculates their sum.
/// 
/// </summary>
class SumIntegers
{
    static void Main()
    {
        // Input
        Console.Write("Enter sequence of positive integer numbers: ");
        string sequence = Console.ReadLine();
        string[] numbers = sequence.Split(' ');

        // Solution
        int sum = Calculate(numbers);

        // Output
        Console.WriteLine("Sum of sequence is " + sum);
    }

    private static int Calculate(string[] numbers)
    {
        int[] numbersInt = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbersInt[i] = int.Parse(numbers[i]);
        }

        return numbersInt.Sum();
    }
}