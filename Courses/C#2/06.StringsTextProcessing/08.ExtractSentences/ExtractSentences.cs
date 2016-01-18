using System;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// Write a program that extracts from a given text all sentences containing given word.
/// Example:
/// The word is: in
/// The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
/// The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
/// Consider that the sentences are separated by . and the words – by non-letter symbols.
/// 
/// </summary>
class ExtractSentences
{
    static void Main()
    {
        // Input
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        // Solution
        StringBuilder result = new StringBuilder();

        string[] sentences = text.Split(new char[] {'.'}, StringSplitOptions.RemoveEmptyEntries);

        for (int index = 0; index < sentences.Length; index++)
        {
            if (sentences[index].Contains(" "+ word + " "))
            {
                result.AppendLine(sentences[index]);
            }
        }

        // Output
        Console.WriteLine();
        Console.WriteLine("The result of search is:");
        Console.WriteLine();
        Console.WriteLine(" " + result);
    }
}