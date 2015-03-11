using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
/// <summary>
/// 
/// Write a program that replaces in a HTML document given as string all the tags <a href= ... >…</a> with corresponding tags [URL=…]…/URL].
/// 
/// </summary>
class ReplaceTags
{   
    static void Main()
    {
        // Input
        Console.Write("Enter HTML document: ");
        string html = Console.ReadLine();

        // Solution
        string replaced = html.Replace(@"<a href=""", "[URL=");
        replaced = replaced.Replace(@""">", "]");
        replaced = replaced.Replace("</a>", "[/URL]");
        // Output
        Console.WriteLine();
        Console.WriteLine(replaced);
    }
}