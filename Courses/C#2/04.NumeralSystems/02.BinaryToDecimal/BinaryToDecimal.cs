using System;
/// <summary>
/// 
/// Write a program to convert binary numbers to their decimal representation.
/// 
/// </summary>
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a Binary number to convert: ");
        string binary = Console.ReadLine();
        long decimalNumber = 0;

        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[binary.Length - i - 1] == '0')
            {
                continue;
            }

            decimalNumber += (long)Math.Pow(2, i);
        }

        Console.WriteLine("Decimal number: " + decimalNumber);
    }
}