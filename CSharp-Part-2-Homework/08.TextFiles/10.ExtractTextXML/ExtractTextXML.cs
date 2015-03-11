using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
/// <summary>
/// 
/// Write a program that extracts from given XML file all the text without the tags.
/// 
/// </summary>
class ExtractTextXML
{
    static void Main()
    {
        try
        {
            // Input
            var reader = new StreamReader(@"..\..\fileFolder\textXML.txt", Encoding.GetEncoding("UTF-8"));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string input = reader.ReadLine();
            StringBuilder textInput = new StringBuilder();

            // Solution
            using (reader)
            {
                while (input != null)
                {
                    textInput.AppendLine(Regex.Replace(input, "<.*?>", " "));
                    input = reader.ReadLine();
                }
            }

            var writer = new StreamWriter(@"..\..\fileFolder\output.txt");

            using (writer)
            {
                writer.Write(textInput.ToString().Trim());
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