using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// C# Part 2 - 2013/2014 @ 14 Sept 2013 - Morning
/// http://bgcoder.com/Contests/94/CSharp-Part-2-2013-2014-14-Sept-2013-Morning
/// 
/// </summary>
class MultiverseCommunication
{
    static void Main()
    {
        // Input
        var alphabet = new List<string>
        {
            "CHU",
            "TEL",
            "OFT",
            "IVA",
            "EMY",
            "VNB",
            "POQ",
            "ERI",
            "CAD",
            "K-A",
            "IIA",
            "YLO",
            "PLA"    
        };

        string input = Console.ReadLine();

        // Solution
        long decimalRepresentation = 0;
        for (int i = 0; i < input.Length; i += 3)
        {
            var digitIn13 = input.Substring(i, 3);

            var decimalValue = alphabet.IndexOf(digitIn13);

            decimalRepresentation *= 13;
            decimalRepresentation += decimalValue;
        }

        // Output
        Console.WriteLine(decimalRepresentation);
    }
}