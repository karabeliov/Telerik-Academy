using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
/// The tags cannot be nested.
/// Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
/// The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
/// 
/// </summary>
class ParseТags
{
    static void Main()
    {
        // Input
        Console.WriteLine("Enter text: ");
        string text = Console.ReadLine();

        // Solution     
        StringBuilder result = new StringBuilder();

        bool isOutTag = true;
        bool isTag = false;
        bool isInTag = false; // upper
        bool slash = false;

        foreach (var ch in text)
        {
            if (isOutTag)
            {
                if (ch == '<')
                {
                    isOutTag = false;
                    isTag = true;
                }
                else
                {
                    result.Append(ch);
                }
            }
            else if (isTag)
            {
                if (ch == '>' && slash == false)
                {
                    isTag = false;
                    isInTag = true;
                }
                else if (ch == '>' && slash == true)
                {
                    isTag = false;
                    isOutTag = true;
                    slash = false;
                }
                else if (ch == '/')
                {
                    isInTag = false;
                    slash = true;
                }
            }
            else if (isInTag)
            {
                if (ch == '<')
                {
                    isTag = true;
                    isInTag = false;
                }
                else
                {
                    result.Append(char.ToUpper(ch));
                }
            }
        }

        // Output
        Console.WriteLine();
        Console.WriteLine(result);
    }
}