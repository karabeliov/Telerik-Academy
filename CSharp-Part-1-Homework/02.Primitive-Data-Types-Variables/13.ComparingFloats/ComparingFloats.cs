using System;
/// <summary>
/// 
/// Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
/// 
/// </summary>
class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter first folating-point number (1.22): ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second folating-point number (1.22): ");
        double secondNumber = double.Parse(Console.ReadLine());
        double precision = 0.000001;
        bool isEqual;
        if (firstNumber >= secondNumber)
        {
            if (firstNumber - secondNumber < precision)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
        }
        else // firstNumber < secondNumber
        {
            if (secondNumber - firstNumber < precision)
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
            }
        }
        Console.WriteLine("Are they equals (with precision eps=0.000001): {0}", isEqual);
    }
}