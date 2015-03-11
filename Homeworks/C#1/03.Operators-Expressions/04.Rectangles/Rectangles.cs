using System;
/// <summary>
/// 
/// Write an expression that calculates rectangle’s perimeter and area by given width and height.
/// 
/// </summary>
class Rectangles
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double perimeter = width * 2 + height * 2;
        double area = width * height;

        Console.WriteLine("Rectangle’s perimeter is: " + perimeter);
        Console.WriteLine("Rectangle’s area is: " + area);
    }
}