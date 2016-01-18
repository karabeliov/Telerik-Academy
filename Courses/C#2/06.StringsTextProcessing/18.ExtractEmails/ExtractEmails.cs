using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
/// <summary>
/// 
/// Write a program for extracting all email addresses from given text.
/// All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
/// 
/// </summary>
class ExtractEmails
{
    static void Main()
    {
        // Input
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        // Solution and Output
        foreach (var item in Regex.Matches(text, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(item);
        }
    }
}