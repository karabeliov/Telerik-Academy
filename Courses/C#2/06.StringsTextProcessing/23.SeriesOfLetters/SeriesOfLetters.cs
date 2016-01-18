using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
/// <summary>
/// 
/// Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
/// 
/// </summary>
class SeriesOfLetters
{
    static void Main()
    {
        // Input
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        // Solution 
        HashSet<string> letters = new HashSet<string>();
        foreach (var item in Regex.Matches(text, @"\w"))
        {
            letters.Add(item.ToString());
        }

        // Output
        foreach (var letter in letters)
        {
            Console.Write(letter);
        }

        Console.WriteLine();
    }
}