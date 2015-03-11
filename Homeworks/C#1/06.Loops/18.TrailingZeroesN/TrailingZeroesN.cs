using System;
using System.Numerics;
/// <summary>
/// 
/// Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
/// Your program should work well for very big numbers, e.g. n=100000.
/// 
/// </summary>
class TrailingZeroesN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        string factorialString = factorial.ToString();
        int counter = 0;
        for (int i = factorialString.Length - 1; i >= 0; i--)
        {
            while (true)
            {
                if (factorialString[i] == '0')
                {
                    counter++;      
                }
                else
                {
                    Console.WriteLine("{0}! has {1} trailing zeros!", number, counter);
                    return;
                }
                break;
            }
        }
    }
}