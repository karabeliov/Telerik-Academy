using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
/// <summary>
/// 
/// Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
/// 
/// </summary>
class Palindromes
{
    static void Main()
    {
        // Input
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        // Solution and Output
        MatchCollection words = Regex.Matches(text, @"\b\w+\b");

        Console.Write("Palindromes in text:   ");
        foreach (var word in words)
        {
            if (IsPalindromes(word.ToString()))
            {
                Console.Write(word + ", ");
            }
        }

        Console.WriteLine();
    }

    private static bool IsPalindromes(string word)
    {
        return word.ToCharArray().SequenceEqual(word.ToCharArray().Reverse());
    }
}