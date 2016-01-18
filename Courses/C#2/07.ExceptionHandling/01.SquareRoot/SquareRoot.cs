using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/07.%20Exception%20Handling/README.md for example
/// Write a program that reads an integer number and calculates and prints its square root.
///  - If the number is invalid or negative, print Invalid number.
///  - In all cases finally print Good bye.
///  Use try-catch-finally block.
/// 
/// </summary>
class SquareRoot
{
    static void Main()
    {
        Console.Write("Enter number: ");
        
        try
        {
            double number = double.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("The number can not be negative.");
            }
            else
            {
                double sqrt = Math.Sqrt(number);
                Console.WriteLine("Squrt of {0} is {1}", number, sqrt);
            }         
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("Value is not entered!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Value overflowed!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        }
    }
}