using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
/// <summary>
/// 
/// Write a program that reads a list of words from the file words.txt and finds how many times each of the words 
/// is contained in another file test.txt.
/// The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
/// Handle all possible exceptions in your methods.
/// 
/// </summary>
class CountWords
{
    static void Main()
    {
        try
        {
            // Input
            StreamReader reader = new StreamReader(@"..\..\fileFolder\test.txt", Encoding.GetEncoding("UTF-8"));
            StreamReader readerWords = new StreamReader(@"..\..\fileFolder\words.txt", Encoding.GetEncoding("UTF-8"));
            StreamWriter writer = new StreamWriter(@"..\..\fileFolder\result.txt", false, Encoding.GetEncoding("UTF-8"));
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string list = readerWords.ReadToEnd();
            string[] words = list.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> counterWords = new Dictionary<string, int>();

            // Solution
            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadToEnd();

                    while (line != null)
                    {
                        string[] wordC = line.Split(new char[]{' ', '.', ',', '!', '?', '\n', '\t', '\r'}, StringSplitOptions.RemoveEmptyEntries);
                        int count = 0;
                        for (int i = 0; i < words.Length; i++)
                        {
                            count = wordC.Count(x => x == words[i]);
                            counterWords.Add(words[i], count); 
                        }

                        line = reader.ReadLine();

                        counterWords.OrderByDescending(x => x.Value);

                        foreach (var word in counterWords)
                        {
                            writer.WriteLine("{0} -> {1} time", word.Key, word.Value);
                        }
                    }
                }
            }

            // Output
            Console.WriteLine("Transfer is done.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Ivalid input");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Can not find file!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Invalid directory in the file path!");
        }
        catch (IOException)
        {
            Console.WriteLine("Can not open the file!");
        }
        catch (Exception)
        {
            Console.WriteLine("Fatal Error!!!");
        }
    }
}