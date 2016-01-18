using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/// <summary>
/// 
/// Write a program that concatenates two text files into another text file.
/// 
/// </summary>
class ConcatenateTextFiles
{
    static void Main()
    {
        try
        {
            // Input
            var reader = new StreamReader(@"..\..\fileFolder\text1.txt", Encoding.GetEncoding("UTF-8"));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string text = string.Empty;

            // Solution
            using (reader)
            {
                text = reader.ReadToEnd();

                reader = new StreamReader(@"..\..\fileFolder\text2.txt", Encoding.GetEncoding("UTF-8"));
                text = text + reader.ReadToEnd();
            }

            // Output
            Console.WriteLine(text);
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