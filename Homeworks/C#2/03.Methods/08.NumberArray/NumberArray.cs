using System;
using System.Linq;
/// <summary>
/// 
/// Write a method that adds two positive integer numbers represented as arrays of digits 
/// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
/// Each of the numbers that will be added could have up to 10 000 digits.
/// 
/// </summary>
class NumberArray
{
    static void Main()
    {
        // Input
        Console.Write("Enter first number: ");
        string fNumber = Console.ReadLine();

        Console.Write("Enter second number: ");
        string sNumber = Console.ReadLine();

        // Solution
        int[] arrayOfDigitFirst = NumberAsArray(fNumber);
        int[] arrayOfDigitSecond = NumberAsArray(sNumber);

        // Output
        Console.WriteLine();
        Console.WriteLine("First Number Digits: {0}", string.Join(", ", arrayOfDigitFirst));
        Console.WriteLine("Second Number Digits: {0}", string.Join(", ", arrayOfDigitSecond));
    }

    private static int[] NumberAsArray(string fNumber)
    {
        int[] array = new int[fNumber.Length];
        int length = fNumber.Length - 1;
        for (int index = 0; index < fNumber.Length; index++)
        {
            array[index] = fNumber[length--] - '0';
        }

        return array;
    }
}