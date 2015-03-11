using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// Write a program that finds all prime numbers in the range [1...10 000 000]
/// 
/// </summary>
class PrimeNumbers
{
    static void Main()
    {
        // Input
        long input = long.Parse(Console.ReadLine());

        bool[] primeNumbers = new bool[input];
        primeNumbers = Enumerable.Repeat(true, 10000001).ToArray();
        primeNumbers[0] = false;
        primeNumbers[1] = false;

        // Solution
        for (long index = 2; (index * index) <= input; index++)
        {
            if (primeNumbers[index] == true)
            {
                for (long j = index * index; j <= input; j += index)
                {
                    primeNumbers[j] = false;
                }
            }
        }

        // Output
        for (long i = 2; i <= input; i++)
        {
            if (primeNumbers[i] == true)
            {
                if (i != 2) // remove coma
                {
                    Console.Write(", {0}", i);
                }
                else
                {
                    Console.Write("{0}", i);
                }             
            }
        }
        Console.WriteLine();
    }
}