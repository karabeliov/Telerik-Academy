using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
/// <summary>
/// 
/// Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
/// 
/// </summary>
class ExtractTextHTML
{
    static void Main()
    {
        // Input
        Console.Write("Enter HTML: ");
        string html = Console.ReadLine();

        Console.WriteLine();
        StringBuilder result = new StringBuilder();
        // Title
        foreach (var item in Regex.Matches(html, @"<title>\s*(.+?)\s*</title>"))
        {
            result.AppendLine(item.ToString());
        }
       
        string title =  RemoveTags(result);
        Console.WriteLine("Title: {0}", title.TrimStart());

        result.Clear();
        // Text 
        foreach (var item in Regex.Matches(html, @"<body>\s*(.+?)\s*</body>"))
        {
            result.AppendLine(item.ToString());
        }

        string body = RemoveTags(result);
        Console.WriteLine("Text: {0}", body.TrimStart());
    }

    private static string RemoveTags(StringBuilder result)
    {
        return Regex.Replace(result.ToString(), "<.*?>", " ");
    }
}