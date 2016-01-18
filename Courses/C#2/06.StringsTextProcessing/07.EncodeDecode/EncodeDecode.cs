using System;
using System.Text;
/// <summary>
/// 
/// Write a program that encodes and decodes a string using given encryption key (cipher).
/// The key consists of a sequence of characters.
/// The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key,
/// the second – with the second, etc. When the last key character is reached, the next is the first.
/// 
/// </summary>
class EncodeDecode
{
    static void Main()
    {
        // Input
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        Console.Write("Enter code: ");
        string key = Console.ReadLine();

        // Solution and Output
        // Encripted
        StringBuilder encriptedString = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            encriptedString.Append((char)(input[i] ^ key[i % key.Length]));
        }

        Console.WriteLine("Encripted: " + encriptedString);

        // Decripted
        StringBuilder decriptString = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            decriptString.Append((char)(encriptedString[i] ^ key[i % key.Length]));
        }

        Console.WriteLine("Decripted: " + decriptString);
    }
}