using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/// <summary>
/// 
/// Write a program that reads a text file and inserts line numbers in front of each of its lines.
/// The result should be written to another text file.
/// 
/// </summary>
class LineNumbers
{
    static void Main()
    {
        try
        {
            // Input
            var reader = new StreamReader(@"..\..\fileFolder\input.txt", Encoding.GetEncoding("UTF-8"));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string input = reader.ReadLine();
            int lineNumber = 0;
            StringBuilder textInput = new StringBuilder();

            // Solution
            using (reader)
            {
                while (input != null)
                {
                    lineNumber++;

                    textInput.AppendLine(string.Format("Line {0}: {1}", lineNumber, input));
                    input = reader.ReadLine();
                }
            }

            var writer = new StreamWriter(@"..\..\fileFolder\output.txt");

            using (writer)
            {
                writer.Write(textInput.ToString().TrimEnd());
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