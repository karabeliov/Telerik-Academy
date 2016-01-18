using System;
/// <summary>
/// 
/// Write a program that calculates the greatest common divisor (GCD) of given two longegers a and b.
/// Use the Euclidean algorithm (find it in longernet).
/// 
/// </summary>
class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        long a = long.Parse(Console.ReadLine());
        Console.Write("b = ");
        long b = long.Parse(Console.ReadLine());
        long remainder = 0;

        while (b != 0)
        {
            remainder = b;
            b = a % b;
        }

        Console.WriteLine("Greatest common divisor: " + remainder);
    }
}