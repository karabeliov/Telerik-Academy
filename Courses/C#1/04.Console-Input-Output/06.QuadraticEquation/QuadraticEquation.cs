using System;
/// <summary>
/// 
/// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
/// 
/// </summary>
class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double disk = Math.Sqrt(b * b - 4 * a * c);
        double x1 = (-b - disk) / (2 * a);
        double x2 = (-b + disk) / (2 * a);

        Console.WriteLine("x1 = " + x1);
        Console.WriteLine("x2 = " + x2);
    }
}