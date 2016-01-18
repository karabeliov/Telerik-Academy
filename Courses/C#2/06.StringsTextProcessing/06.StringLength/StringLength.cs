using System;
/// <summary>
/// 
/// Write a program that reads from the console a string of maximum 20 characters. 
/// If the length of the string is less than 20, the rest of the characters should be filled with *.
/// Print the result string into the console.
/// 
/// </summary>
class StringLength
{
    static void Main()
    {
        // Input
        Console.Write("Enter string with maximum 20 characters: ");
        string input = Console.ReadLine();

        if (input.Length > 20)
        {
            Console.WriteLine();
            Console.WriteLine("Error!!! Your input is bigger then 20 characters");
            return;
        }
        // Solution
        char[] characters = new char[20];

        // Full Array with character '*'
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i] = '*';
        }

        // Enter character of input to Array
        for (int i = 0; i < input.Length; i++)
        {
            characters[i] = input[i];
        }

        // Output
        Console.WriteLine(string.Join(", ", characters));

    }
}