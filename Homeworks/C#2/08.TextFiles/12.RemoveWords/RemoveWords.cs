using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
/// <summary>
/// 
/// Write a program that removes from a text file all words listed in given another text file.
/// Handle all possible exceptions in your methods.
/// 
/// </summary>
class RemoveWords
{
    static void Main()
    {
        try
        {
            // Input
            StreamReader reader = new StreamReader(@"..\..\fileFolder\text.txt", Encoding.GetEncoding("UTF-8"));
            StreamReader readerWords = new StreamReader(@"..\..\fileFolder\wordsList.txt", Encoding.GetEncoding("UTF-8"));
            StreamWriter writer = new StreamWriter(@"..\..\fileFolder\temp.txt", false, Encoding.GetEncoding("UTF-8"));
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string list = readerWords.ReadToEnd();
            string[] words = list.Split(new char[]{' ', ','}, StringSplitOptions.RemoveEmptyEntries);

            // Solution
            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        for (int i = 0; i < words.Length; i++)
                        {
                            line = Regex.Replace(line, words[i] + @"\b", string.Empty); 
                        }
                        
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }

            File.Delete(@"..\..\fileFolder\text.txt");
            File.Move(@"..\..\fileFolder\temp.txt", @"..\..\fileFolder\text.txt");

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