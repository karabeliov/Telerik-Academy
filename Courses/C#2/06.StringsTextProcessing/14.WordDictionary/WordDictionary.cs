using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// A dictionary is stored as a sequence of text lines containing words and their explanations.
/// Write a program that enters a word and translates it by using the dictionary.
/// 
///     input	      |                   output
///                   |
///     .NET	      |  platform for applications from Microsoft
///     CLR	          |  managed execution environment for .NET
///     namespace	  |  hierarchical organization of classes
/// 
/// </summary>
class WordDictionary
{
    static void Main()
    {
        // Input
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        // Solution
        Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase); // IgnoreCase
        dictionary.Add(".NET", "platform for applications from Microsoft");
        dictionary.Add("CLR", "managed execution environment for .NET");
        dictionary.Add("Namespace", "hierarchical organization of classes");
        dictionary.Add("Telerik Academy", "intensive training program for software engineers");

        // Output
        if (dictionary.ContainsKey(word))
        {
            Console.WriteLine("{0} is {1}", word.ToUpper(), dictionary[word]);
        }
        else
        {
            Console.WriteLine("{0} is not found in dictionary!", word);
        }
    }
}