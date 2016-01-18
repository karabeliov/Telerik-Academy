using System;
using System.Text;
/// <summary>
/// 
/// Find online more information about ASCII (American Standard Code for Information Interchange) 
/// and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
/// 
/// </summary>
class PrintASCIITable
{
    static void Main()
    {
        // Console.OutputEncoding = Encoding.ASCII;
        for (int i = 0; i <= 255; i++)
        {
            char characters = (char)i;
            if (Char.IsLetterOrDigit(characters) || Char.IsSymbol(characters))
            {
                Console.WriteLine("{0} -> {1}",i,characters);
            }
            else if (Char.IsSeparator(characters))
            {
                Console.WriteLine("{0} -> ?", i, characters);
            }
            else
            {
                Console.WriteLine("{0} -> {1}", i, characters);
            }
        }
    }
}