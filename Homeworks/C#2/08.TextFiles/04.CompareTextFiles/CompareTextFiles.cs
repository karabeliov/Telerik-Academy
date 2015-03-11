using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/// <summary>
/// 
/// Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
/// Assume the files have equal number of lines.
/// 
/// </summary>
class CompareTextFiles
{
    static void Main()
    {
        try
        {
            // Input
            var readerForTXT1 = new StreamReader(@"..\..\fileFolder\text1.txt", Encoding.GetEncoding("UTF-8"));
            var readerForTXT2 = new StreamReader(@"..\..\fileFolder\text2.txt", Encoding.GetEncoding("UTF-8"));
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string text1 = string.Empty;
            string text2 = string.Empty;

            int countSame = 0;
            int countDifferent = 0;
            bool isDifferent = false;

            // Solution
            using (readerForTXT1)
            {
                using (readerForTXT2)
                {
                    while (text1 != null && text2 != null)
                    {
                        text1 = readerForTXT1.ReadLine();
                        text2 = readerForTXT2.ReadLine();

                        if (text1 != null && text2 != null)
                        {
                            isDifferent = text1.Equals(text2);
                        }
                        else
                        {
                            continue;
                        }

                        if (isDifferent)
                        {
                            countSame++;
                        }
                        else
                        {
                            countDifferent++;
                        }
                    }
                }
            }

            // Output
            Console.WriteLine("The same line is: {0}", countSame);
            Console.WriteLine("The different line is: {0}", countDifferent);
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