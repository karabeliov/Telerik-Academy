using System;
using System.Text;
/// <summary>
/// 
/// Write a program that converts a string to a sequence of C# Unicode character literals.
/// Use format strings.
/// 
/// </summary>
class UnicodeCharacters
{
    static void Main()
    {
        // Input
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        // Solution
        StringBuilder result = new StringBuilder();
        for (int index = 0; index < input.Length; index++)
        {
            result.Append(string.Format("{0}{1}", @"\u", ((int)input[index]).ToString("X").PadLeft(4, '0')));
        }

        // Output
        Console.WriteLine(result);
    }
}