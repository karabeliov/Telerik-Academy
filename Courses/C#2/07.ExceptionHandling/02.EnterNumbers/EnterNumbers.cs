using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
///  - If an invalid number or non-number text is entered, the method should throw an exception.
/// Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
/// 
/// </summary>
class EnterNumbers
{
    static void Main()
    {
        int min = 1;
        int max = 100;
        const int fixSizeOfNumbers = 10;
        int[] numbers = new int[fixSizeOfNumbers];

        // Input
        Console.Write("Enter start number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end number: ");
        int end = int.Parse(Console.ReadLine());

        // Check for valid input
        if (start > end )
        {
            Console.WriteLine("Start can not be bigger then End!");
            return;
        }
        else if (start > 100 || end > 100)
        {
            Console.WriteLine("Start or End number can not be bigger then 100!");
            return;
        }
        else if (start < 1 || end < 1)
        {
            Console.WriteLine("Start or End number can not be smaller then 1!");
            return;
        }

        // Solution and Output
        try
        {
            numbers[0] = EnterNumber(start, end);
            for (int i = 1; i < numbers.Length; i++)
            {
                min = numbers[i - 1];
                numbers[i] = EnterNumber(min, max);
            }
        }
        catch (Exception invalidNumber)
        {
            Console.WriteLine(invalidNumber.Message);
        }     
    }

    private static int EnterNumber(int start, int end)
    {

        Console.Write("Enter number between [{0} and {1}] = ", start, end);
        int number = int.Parse(Console.ReadLine());

        if (number < start || number > end)
        {
            throw new Exception("Ivalide range entered!");
        }

        return number;
    }
}