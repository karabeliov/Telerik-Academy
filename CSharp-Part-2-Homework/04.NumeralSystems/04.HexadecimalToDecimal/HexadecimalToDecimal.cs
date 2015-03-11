using System;
/// <summary>
/// 
/// Write a program to convert hexadecimal numbers to their decimal representation.
/// 
/// </summary>
class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string hexadecimal = Console.ReadLine();
        long decimalNumber = 0;
        long pow = 1;

        for (int position = hexadecimal.Length - 1; position >= 0; position--)
        {
            int digit;
            switch (hexadecimal[position])
            {
                case 'A': digit = 10;
                    break;
                case 'B': digit = 11;
                    break;
                case 'C': digit = 12;
                    break;
                case 'D': digit = 13;
                    break;
                case 'E': digit = 14;
                    break;
                case 'F': digit = 15;
                    break;
                default: digit = hexadecimal[position] - 48;
                    break;
            }
            decimalNumber += digit * pow;
            pow *= 16;
        }

        Console.WriteLine("Decimal number: " + decimalNumber);
    }
}