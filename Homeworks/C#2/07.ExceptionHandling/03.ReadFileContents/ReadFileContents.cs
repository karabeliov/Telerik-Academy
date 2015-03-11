using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;
/// <summary>
/// 
/// ite a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
/// Find in MSDN how to use System.IO.File.ReadAllText(…).
/// Be sure to catch all possible exceptions and print user-friendly error messages.
/// 
/// </summary>
class ReadFileContents
{
    static void Main()
    {
        try
        {
            // Input
            Console.Write("Enter file name with file path: ");
            string filePath = Console.ReadLine();

            // Solution
            string readFile = File.ReadAllText(filePath);
            Match fileName = Regex.Match(filePath, @"\b\w+\\([A-Za-z0-9\-]+)\.", RegexOptions.IgnoreCase);

            // Output
            Console.WriteLine();
            Console.WriteLine("Contents in file {0} is:", fileName.Groups[1].Value);
            Console.WriteLine(readFile);
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid path or file name");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The specified path is invalid.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Path specified a file that is read-only.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Path is in an invalid format.");
        }
        catch (IOException)
        {
            Console.WriteLine("An I/O error occurred while opening the file.");
        }
        catch (SecurityException)
        {
            Console.WriteLine("The caller does not have the required permission.");
        }
    }
}