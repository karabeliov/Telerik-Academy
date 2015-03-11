using System;
/// <summary>
/// 
/// https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/04.%20Numeral%20Systems/README.md for example
/// Write a program to convert decimal numbers to their binary representation.
/// 
/// </summary>
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        long rest;
        string binaryNumber = null;

        while (decimalNumber > 0)
        {
            rest = decimalNumber % 2;
            decimalNumber /= 2;
            binaryNumber = rest.ToString() + binaryNumber;
        }

        Console.WriteLine("Binary number: " + binaryNumber);
    }
}