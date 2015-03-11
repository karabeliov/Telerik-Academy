using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// Write a program that reads a string from the console and lists all different words in 
/// the string along with information how many times each word is found.
/// 
/// </summary>
class WordsCount
{
    static void Main()
    {
        // Input
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        // Solution and Output
        string[] words = text.Split(' ', '.', ',', '!', '?', '-');
        for (int i = 0; i < words.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < i; j++)
            {
                if (words[i] == words[j])
                {
                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                int count = words.Count(x => x == words[i]);
                string word = words[i];
                Console.WriteLine("{0} -> {1} time", words[i], count);
            }
        }
    }
}