using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
/// <summary>
/// 
/// C# Part 2 - 2013/2014 @ 22 Jan 2014 - Evening
/// http://bgcoder.com/Contests/Practice/Index/142#0
/// 
/// </summary>
class TRES4Numbers
{
    static void Main()
    {
        // Input
        ulong input = ulong.Parse(Console.ReadLine());
        
        string[] digitsTRES4 = new string[]
            {
               "LON+" ,
               "VK-"  ,
               "*ACAD",
               "^MIM" ,
               "ERIK|",
               "SEY&" ,
               "EMY>>",
               "/TEL" ,
               "<<DON"
            };

        // Solution
        StringBuilder result = new StringBuilder();

        if (input == 0)
        {
            result.Append(digitsTRES4[0]);
        }
        else
        {
            while (input > 0)
            {
                int digitIn9 = (int)(input % (ulong)9);
                result.Insert(0, digitsTRES4[digitIn9]);
                input /= (ulong)9;
            }
        }
        
        // Output
        Console.WriteLine(result.ToString());
    }
}