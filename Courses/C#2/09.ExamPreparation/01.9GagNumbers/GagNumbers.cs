using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
/// <summary>
/// 
/// C# Part 2 - 2012/2013 @ 11 Feb 2013
/// http://bgcoder.com/Contests/55/CSharp-Part-2-2012-2013-11-Feb-2013
/// 
/// </summary>
class GagNumbers
{
    static void Main()
    {
        Dictionary<string, int> gagNumbers = new Dictionary<string, int>()
        {
            {"-!", 0},
            {"**", 1},
            {"!!!", 2},
            {"&&", 3},
            {"&-", 4},
            {"!-", 5},
            {"*!!!", 6},
            {"&*!", 7},
            {"!!**!-", 8}
        };

        string input = Console.ReadLine();

        StringBuilder part = new StringBuilder();
        string currentDigit = string.Empty;
        for (int i = 0; i < input.Length; i++)
        {
            part.Append(input[i]);

            try
            {
                currentDigit += gagNumbers[part.ToString()].ToString();
                part.Clear();
            }
            catch (Exception)
            {
                continue;
            }
        }

        // Solution
        BigInteger decimalRepresentation = 0; // output Numeric
        for (int i = 0; i < currentDigit.Length; i++)
        {
            BigInteger digit = currentDigit[i] - '0';
            decimalRepresentation += digit * Pow(currentDigit.Length - i - 1); // !!!
        }

        // Output
        Console.WriteLine(decimalRepresentation);
    }

    static BigInteger Pow(int pow) // Power
    {
        BigInteger result = 1;

        for (int i = 0; i < pow; i++)
        {
            result *= 9; // base
        }

        return result;
    }
}