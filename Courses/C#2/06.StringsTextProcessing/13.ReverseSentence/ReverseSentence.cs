using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// Write a program that reverses the words in given sentence.
/// 
/// </summary>
class ReverseSentence
{
    static void Main()
    {
        Console.Write("Enter sentence of words: ");
        string sentence = Console.ReadLine();

        int indexComa = sentence.IndexOf(',');
        string[] words = sentence.Split(new char[] { ' ', '!', ',' }, StringSplitOptions.RemoveEmptyEntries);

        StringBuilder result = new StringBuilder();
        for (int index = words.Length - 1; index >= 0; index--)
        {
            if (index != 0)
            {
                result.Append(words[index] + " ");
            }
            else
            {
                result.Append(words[index]);
            }
        }

        result.Insert(indexComa + 5, ',');
        Console.WriteLine(result + "!");
    }
}