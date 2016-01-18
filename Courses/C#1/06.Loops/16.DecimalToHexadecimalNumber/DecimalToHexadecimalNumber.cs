using System;
/// <summary>
/// 
/// Using loops write a program that converts an integer number to its hexadecimal representation.
/// The input is entered as long. The output should be a variable of type string.
/// Do not use the built-in .NET functionality.
/// 
/// </summary>
class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        long rest;
        string hexadecimal = null;

        if (decimalNumber == 0)
        {
            Console.WriteLine("Hexadecimal number: 0");
        }
        else
        {
            while (decimalNumber > 0)
            {
                rest = decimalNumber % 16;

                switch (rest)
                {
                    case 10: hexadecimal += 'A';
                        break;
                    case 11: hexadecimal += 'B';
                        break;
                    case 12: hexadecimal += 'C';
                        break;
                    case 13: hexadecimal += 'D';
                        break;
                    case 14: hexadecimal += 'E';
                        break;
                    case 15: hexadecimal += 'F';
                        break;
                    default: hexadecimal += rest.ToString();
                        break;
                }

                decimalNumber /= 16;
            }

            Console.Write("Hexadecimal number: ");
            for (int position = hexadecimal.Length - 1; position >= 0; position--)
            {
                Console.Write(hexadecimal[position]);
            }

            Console.WriteLine();
        }
    }
}