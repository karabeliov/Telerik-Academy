using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/// <summary>
/// 
/// Write a program that deletes from given text file all odd lines.
/// The result should be in the same file.
/// 
/// </summary>
class DeleteOddLines
{
    static void Main()
    {
        try
        {
            // Input           
            StreamReader reader = new StreamReader(@"..\..\fileFolder\text.txt", Encoding.GetEncoding("UTF-8"));
            StreamWriter writer = new StreamWriter(@"..\..\fileFolder\temp.txt", false, Encoding.GetEncoding("UTF-8"));
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Solution
            using (reader)
            {
                using (writer)
                {
                    string line = reader.ReadLine();
                    int counter = 1;

                    while (line != null)
                    {
                        if (counter % 2 == 0)
                        {
                            writer.WriteLine(line);
                        }
                        line = reader.ReadLine();
                        counter++;
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