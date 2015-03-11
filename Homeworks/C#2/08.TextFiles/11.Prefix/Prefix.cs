using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
/// <summary>
/// 
/// Write a program that deletes from a text file all words that start with the prefix test.
/// Words contain only the symbols 0…9, a…z, A…Z, _.
/// 
/// </summary>
class Prefix
{
    static void Main()
    {
        try
        {
            // Input
            StreamReader reader = new StreamReader(@"..\..\fileFolder\text.txt", Encoding.GetEncoding("UTF-8"));
            StreamWriter writer = new StreamWriter(@"..\..\fileFolder\temp.txt", false, Encoding.GetEncoding("UTF-8"));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string removeWord = "test"; 

            // Solution
            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        line = Regex.Replace(line, removeWord + @"\b", string.Empty); // remove exact this word
                        line = Regex.Replace(line, removeWord + @"\w+", string.Empty); // remove similar words
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