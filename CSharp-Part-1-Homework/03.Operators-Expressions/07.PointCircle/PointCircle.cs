using System;
/// <summary>
/// 
/// Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
/// 
/// </summary>
class PointCircle
{
    static void Main()
    {
        // K({X, Y}, 2)
        // R² > [ (Xт - X)² + (Yт - Y)² ]
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        int r = 2;
        bool inside = r * r > (Math.Pow((0 - x), 2) ) + ( Math.Pow((0 - x), 2) );

        Console.WriteLine(inside);
    }
}