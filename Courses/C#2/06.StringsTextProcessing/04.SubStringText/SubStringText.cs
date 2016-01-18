using System;
using System.Linq;
/// <summary>
/// 
/// Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
/// Example:
/// The target sub-string is in
/// The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
/// The result is: 9
/// 
/// </summary>
class SubStringText
{
    static void Main()
    {
        // Input
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter sub-string: ");
        string subString = Console.ReadLine();

        // Solution
        int count = text.Select((c, i) => text.Substring(i)).Count(sub => sub.StartsWith(subString));

        // Output
        Console.WriteLine();
        Console.WriteLine("Substring [{0}] is find {1} time", subString, count);
    }
}