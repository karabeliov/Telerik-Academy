using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// Write a program that reads a string from the console and prints all different letters 
/// in the string along with information how many times each letter is found.
/// 
/// </summary>
class LettersCount
{
    static void Main()
    {
        // Input
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        // Solution and Output
        text = text.ToLower();
        for (int i = 97; i < 97 + 26; i++)
        {
            int letter = text.Count(x => x == (char)i);
            Console.WriteLine("{0} -> {1} time",(char)i, letter);
        }      
    }
}