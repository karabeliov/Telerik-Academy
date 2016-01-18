using System;
/// <summary>
/// 
/// Using loops write a program that converts an integer number to its binary representation.
/// The input is entered as long. The output should be a variable of type string.
/// Do not use the built-in .NET functionality.
/// 
/// </summary>
class DecimalТoBinaryNumber
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