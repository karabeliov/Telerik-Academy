using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
/// 
/// </summary>
class OrderWords
{
    static void Main()
    {
        // Input
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        // Solution
        string[] words = text.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
        words = words.OrderBy(x => x).ToArray();

        // Output
        Console.WriteLine();
        Console.WriteLine("Words is sorted by alphabetical order:");
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}