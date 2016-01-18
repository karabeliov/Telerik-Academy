using System;
/// <summary>
/// 
/// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
/// 
/// </summary>
class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Enter base \"S\" for first Number: ");
        int baseS = int.Parse(Console.ReadLine());

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("Enter base \"D\" for first Number: ");
        int baseD = int.Parse(Console.ReadLine());
        byte powerCounter = 0;
        int decimalNumber = 0;

        while (number != 0)
        {
            byte lastDigit = (byte)(number % 10);
            decimalNumber += lastDigit * (int)Math.Pow(baseS, powerCounter);
            powerCounter++;
            number /= 10;
        }

        string result = null;

        while (decimalNumber != 0)
        {
            byte lastDigit = (byte)(decimalNumber % baseD);
            result = lastDigit + result;
            decimalNumber /= baseD;
        }

        Console.WriteLine();
        Console.WriteLine("Result is " + result);
    }
}