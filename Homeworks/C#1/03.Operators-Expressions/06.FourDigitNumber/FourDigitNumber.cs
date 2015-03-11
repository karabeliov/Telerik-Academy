using System;
/// <summary>
/// 
/// Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
/// Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
/// Prints on the console the number in reversed order: dcba (in our example 1102).
/// Puts the last digit in the first position: dabc (in our example 1201).
/// Exchanges the second and the third digits: acbd (in our example 2101).
/// The number has always exactly 4 digits and cannot start with 0.
/// 
/// </summary>
class FourDigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int firstDigit = number % 10000;
        firstDigit /= 1000;

        int secondDigit = number % 1000;
        secondDigit /= 100;

        int thirdDigit = number % 100;
        thirdDigit /= 10;

        int fourDigit = number % 10;
        fourDigit /= 1;

        int sum = firstDigit + secondDigit + thirdDigit + fourDigit;

        Console.WriteLine("Sum of digits: " + sum);
        Console.WriteLine("Reversed: {3}{2}{1}{0}", firstDigit, secondDigit, thirdDigit, fourDigit);
        Console.WriteLine("Last digit in front: {3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourDigit);
        Console.WriteLine("Second and third digits exchanged: {0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourDigit);
    }
}