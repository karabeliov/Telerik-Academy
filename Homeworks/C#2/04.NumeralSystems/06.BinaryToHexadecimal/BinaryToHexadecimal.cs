using System;
/// <summary>
/// 
/// Write a program to convert binary numbers to hexadecimal numbers (directly).
/// 
/// </summary>
class BinaryToHexadecimal
{
    static void Main()
    {
        // Input
        Console.Write("Enter Binary  Number: ");
        string hex = Console.ReadLine();

        // Solution
        string binary = Convert.ToInt32(hex, 2).ToString("X");

        // Output
        Console.WriteLine("Hexadecimal representation: {0}", binary);
    }
}