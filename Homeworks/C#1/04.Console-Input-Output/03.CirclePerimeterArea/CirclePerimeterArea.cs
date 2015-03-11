using System;
/// <summary>
/// 
/// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
/// 
/// </summary>
class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write("radius =  ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2*Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("Perimeter: {0:f2}", perimeter);
        Console.WriteLine("Area: {0:f2}", area);
    }
}