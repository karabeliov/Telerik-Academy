using System;
/// <summary>
/// 
/// Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
/// Format the output aligned right in 15 symbols.
/// 
/// </summary>
class FormatNumber
{
    static void Main()
    {
        // Input
        Console.Write("Enter number: ");  // example number 9149022338 
        long number = long.Parse(Console.ReadLine());

        // Solution
        string hex = number.ToString("X"); // represent number to hexadecimal number
        string percentage = number.ToString("P"); // represent number to percentage
        string scientificNotation = number.ToString("E2"); // represent number to scientific notation

        // Output
        Console.WriteLine("{0,15} (Decimal)", number);
        Console.WriteLine("{0,15} (Hexadecimal)", hex);
        Console.WriteLine("{0,15} (Percentage)", percentage);
        Console.WriteLine("{0,15} (Scientific notation)", scientificNotation);
    }
}