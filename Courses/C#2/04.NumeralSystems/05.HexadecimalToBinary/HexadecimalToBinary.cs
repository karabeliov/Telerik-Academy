using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 
/// Write a program to convert hexadecimal numbers to binary numbers (directly).
/// 
/// </summary>
class HexadecimalToBinary
{
    static void Main()
    {
        // Input
        Console.Write("Enter Hexadecimal Number: ");
        string hex = Console.ReadLine();

        // Solution
        string binary = HexStringToBinary(hex);

        // Output
        Console.WriteLine("Binary representation: {0}", binary);

    }

    private static string HexStringToBinary(string hex)
    {
        StringBuilder result = new StringBuilder();
        foreach (char c in hex)
        {
            result.Append(hexToBinary[char.ToLower(c)]);
        }
        return result.ToString();
    }

    private static Dictionary<char, string> hexToBinary = new Dictionary<char, string> 
    {
        { '0', "0000" },
        { '1', "0001" },
        { '2', "0010" },
        { '3', "0011" },
        { '4', "0100" },
        { '5', "0101" },
        { '6', "0110" },
        { '7', "0111" },
        { '8', "1000" },
        { '9', "1001" },
        { 'a', "1010" },
        { 'b', "1011" },
        { 'c', "1100" },
        { 'd', "1101" },
        { 'e', "1110" },
        { 'f', "1111" }
    };
}