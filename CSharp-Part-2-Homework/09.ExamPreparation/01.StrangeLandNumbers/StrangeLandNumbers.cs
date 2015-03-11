using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
/// <summary>
/// 
/// C# Part 2 - 2013/2014 @ 24 Jan 2014 - Evening
/// http://bgcoder.com/Contests/143/CSharp-Part-2-2013-2014-24-Jan-2014-Evening
/// 
/// </summary>
class StrangeLandNumbers
{
    static void Main()
    {
        // Input 
        string input = Console.ReadLine() // slow
            .Replace("f", "0")
            .Replace("bIN", "1")
            .Replace("oBJEC", "2")
            .Replace("mNTRAVL", "3")
            .Replace("lPVKNQ", "4")
            .Replace("pNWE", "5")
            .Replace("hT", "6");

        // Solution
        int power = 0;
        BigInteger result = 0;
        for (int index = input.Length - 1; index >= 0; index--)
        {
            int currentNumber = input[index] - '0';
            result += currentNumber * Power(7, power);

            power++;
        }

        // Output
        Console.WriteLine(result);
    }

    private static BigInteger Power(int currentNumber, int power)
    {
        BigInteger result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= currentNumber;
        }

        return result;
    }
}