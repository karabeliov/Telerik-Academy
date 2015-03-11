using System;
/// <summary>
/// 
/// Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.   
/// 
/// </summary>
class UnicodeCharacter
{
    static void Main()
    {
        char star = '\u002a';

        Console.WriteLine(star);
    }
}