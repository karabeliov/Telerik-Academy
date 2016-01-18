using System;
using System.Linq;
/// <summary>
/// 
/// Write a method that reverses the digits of given decimal number.
/// 
/// </summary>
class ReverseNumber
{
    static void Main()
    {
        // Input
        Console.Write("Enter number to reverse: ");
        double number = double.Parse(Console.ReadLine());

        // Solution and Output
        ReverseAndPrint(number);
    }

    private static void ReverseAndPrint(double number)
    {
        string strNumber = number.ToString();
        char[] array = strNumber.ToArray();

        Array.Reverse(array);

        Console.WriteLine(array);
    }
}