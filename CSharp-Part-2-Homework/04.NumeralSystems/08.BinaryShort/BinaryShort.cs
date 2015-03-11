using System;
/// <summary>
/// 
/// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
/// 
/// </summary>
class BinaryShort
{
    static void Main()
    {
        // Input
        Console.Write("Enter number of type \"Short\"(from -32768 to 32767): ");
        short number = short.Parse(Console.ReadLine());

        // Solution
        string binary = Convert.ToString(number, 2).PadLeft(16, '0');

        // Output
        Console.WriteLine();
        Console.WriteLine("Binary representation " + binary);
    }
}