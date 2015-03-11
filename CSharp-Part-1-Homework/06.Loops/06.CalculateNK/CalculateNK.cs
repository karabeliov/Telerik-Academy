using System;
using System.Numerics;
/// <summary>
/// 
/// Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
/// Use only one loop.
/// 
/// </summary>
class CalculateNKulateNK
{
    static void Main()
    {
        Console.Write("Enter first number between 1..100: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter second number between 1..100: ");
        int k = int.Parse(Console.ReadLine());
        BigInteger result = 1;

        if (1 < k && n > k && n < 100)
        {
            result = Factorial(n) / Factorial(k);
            Console.WriteLine("N!/!K = {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }

    private static BigInteger Factorial(int n)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}