using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
/// <summary>
/// 
/// Modify the solution of the previous problem to replace only whole words (not strings).
/// 
/// </summary>
class ReplaceWholeWord
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

                    while (line != null)
                    {
                        line = Regex.Replace(line, @"start\b", "finish");
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }

            // File.Delete("../../fileFolder/text.txt"); this comand delete file 
            File.Move(@"..\..\fileFolder\temp.txt", @"..\..\fileFolder\copyText.txt");

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