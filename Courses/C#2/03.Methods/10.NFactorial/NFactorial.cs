using System;
using System.Numerics;
/// <summary>
/// 
/// Write a program to calculate n! for each n in the range [1..100].
/// 
/// </summary>
class NFactorial
{
    static void Main()
    {
        // Input
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        // Solution
        BigInteger factorialN = Factorial(number);

        // Output
        Console.WriteLine();
        Console.WriteLine("Factorial of {0}! is {1}", number, factorialN);
    }

    private static BigInteger Factorial(int number)
    {
        if (number <= 1)
        {
            return 1;
        }

        return number * Factorial(number - 1); // recursive
    }
}