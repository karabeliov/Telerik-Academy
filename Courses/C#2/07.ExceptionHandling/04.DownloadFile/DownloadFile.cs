using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
/// <summary>
/// 
/// Write a program that downloads a file from Internet (e.g. Ninja image)| http://telerikacademy.com/Content/Images/news-img01.png | 
/// and stores it the current directory.
/// Find in Google how to download files in C#.
/// Be sure to catch all exceptions and to free any used resources in the finally block.
/// 
/// </summary>
class DownloadFile
{
    static void Main()
    {
        // Input
        Console.Write("Enter URL of the file: ");
        string url = Console.ReadLine();  // http://telerikacademy.com/Content/Images/news-img01.png

        Console.Write("Enter path to local disk: ");
        string path = Console.ReadLine();  //  C:\Users\***Your User Name***\Desktop\ninja.png
        
        // Solution and Output
        try
        {
            WebClient downloadFile = new WebClient();
            downloadFile.DownloadFile(url, path);
        }
        catch (ArgumentException)
        {
            Console.WriteLine();
            Console.WriteLine("The URL address is null.");
        }
        catch (WebException)
        {
            Console.WriteLine();
            Console.WriteLine("Address is invalid or filename is null or file does not exist or an error occurred while downloading data.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine();
            Console.WriteLine("The method has been called simultaneously on multiple threads.");
        }
    }
}