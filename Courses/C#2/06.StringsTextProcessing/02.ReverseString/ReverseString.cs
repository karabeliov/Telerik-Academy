using System;
using System.Linq;
/// <summary>
/// 
/// https://github.com/TelerikAcademy/CSharp-Part-2/tree/master/06.%20Strings%20and%20Text%20Processing for example 
/// Write a program that reads a string, reverses it and prints the result at the console.
/// 
/// </summary>
class ReverseString
{
    static void Main()
    {
        // Input
        Console.Write("Enter string to reversed: ");
        string input = Console.ReadLine();

        // Solution
        var reversed = input.Reverse();

        // Output
        Console.Write("Reversed string is: ");
        Console.WriteLine(string.Join("",reversed));
    }
}