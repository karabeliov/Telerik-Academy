using System;
/// <summary>
/// 
/// Using loops write a program that converts a hexadecimal integer number to its decimal form.
/// The input is entered as string. The output should be a variable of type long.
/// Do not use the built-in .NET functionality.
/// 
/// </summary>
class HexadecimalToDecimalNumber
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