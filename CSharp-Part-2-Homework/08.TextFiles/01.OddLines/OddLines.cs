using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/08.%20Text%20Files/README.md for example
/// Write a program that reads a text file and prints on the console its odd lines.
/// 
/// </summary>
class OddLines
{
    static void Main()
    {
        try
        {
            // Input
            var reader = new StreamReader(@"..\..\fileFolder\text.txt", Encoding.GetEncoding("UTF-8"));
            var writer = new StreamWriter(@"..\..\fileFolder\copyText.txt", false, Encoding.GetEncoding("UTF-8"));
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Solution and Output
            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    int counter = 1;

                    while (line != null)
                    {
                        if (counter % 2 != 0)
                        {
                            writer.WriteLine(line);
                            Console.WriteLine("Line {0}: {1}", counter, line);
                        }

                        line = reader.ReadLine();
                        counter++;
                    }
                }
            }
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