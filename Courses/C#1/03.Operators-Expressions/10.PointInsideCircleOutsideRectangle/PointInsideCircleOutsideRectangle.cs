﻿using System;
/// <summary>
/// 
/// Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle
/// R(top=1, left=-1, width=6, height=2)
/// 
/// </summary>
class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double r = 1.5;
        bool insideK = r * r > (Math.Pow((x - 1), 2)) + (Math.Pow((y - 1), 2));
        bool outsideR = x >= -1 && x <= 4 && y >= -1 && y <= 1;

        if (insideK && !outsideR)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}