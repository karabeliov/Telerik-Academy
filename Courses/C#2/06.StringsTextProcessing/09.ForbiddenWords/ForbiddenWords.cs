using System;
using System.Text;
/// <summary>
/// 
/// We are given a string containing a list of forbidden words and a text containing some of these words.
/// Write a program that replaces the forbidden words with asterisks.
/// 
/// Example text: Microsoft announced its next generation PHP compiler today. 
/// It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
/// Forbidden words: PHP, CLR, Microsoft
/// 
/// The expected result: ********* announced its next generation *** compiler today. 
/// It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
/// 
/// </summary>
class ForbiddenWords
{
    static void Main()
    {
        // Input
        Console.Write("Enter how many words is forbidden: ");
        int n = int.Parse(Console.ReadLine()); // number of forbidden words
        Console.WriteLine();
        string[] forbiddenWords = new string[n];
        
        for (int index = 0; index < forbiddenWords.Length; index++)
        {
            Console.Write("Enter {0} forbidden word: ", index + 1);
            forbiddenWords[index] = Console.ReadLine();
        }

        Console.WriteLine();
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        
        // Solution
        for (int index = 0; index < n; index++)
        {
            text = text.Replace(forbiddenWords[index], new string('*', forbiddenWords[index].Length));
        }

        // Output
        Console.WriteLine();
        Console.WriteLine(text);
    }
}