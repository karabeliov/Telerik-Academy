using System;
using System.Numerics;
/// <summary>
/// 
/// In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
/// Write a program to calculate the nth Catalan number by given n (1 < n < 100).
/// 
/// </summary>
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger result = 1;
        if (0 <= n && n < 100)
        {
            //C = (2N)! / ((N + 1)! * N!)
            result = factorial(2 * n) / (factorial(n + 1) * factorial(n));
            Console.WriteLine("Catalan Number = " + result);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }

    private static BigInteger factorial(int n)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}