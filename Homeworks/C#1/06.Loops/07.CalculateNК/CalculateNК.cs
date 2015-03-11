using System;
using System.Numerics;
/// <summary>
/// 
/// In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations)
/// is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
/// Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
/// 
/// </summary>
class CalculateNК
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
            result = Factorial(n) / (Factorial(k) * Factorial(n-k));
            Console.WriteLine("N! / (K! * (N-K)! = {0}", result);
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