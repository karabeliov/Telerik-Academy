using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/// <summary>
/// 
/// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
/// 
/// </summary>
class SaveSortedNames
{
    static void Main()
    {
        try
        {
            // Input
            var reader = new StreamReader(@"..\..\fileFolder\input.txt", Encoding.GetEncoding("UTF-8"));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string input = reader.ReadLine();

            var textInput = new List<string>();

            // Solution
            using (reader)
            {
                while (input != null)
                {
                    textInput.Add(input);
                    input = reader.ReadLine();
                }
            }

            var writer = new StreamWriter(@"..\..\fileFolder\output.txt");
            textInput.Sort(); // Sorted

            using (writer)
            {
                writer.Write(string.Join("\n", textInput));
            }

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