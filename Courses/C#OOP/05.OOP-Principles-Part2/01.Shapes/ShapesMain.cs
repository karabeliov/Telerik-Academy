namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ShapesMain
    {
        static void Main()
        {
            Rectangle quad = new Rectangle(4, 4);
            Triangle tri = new Triangle(5, 6);

            // double surfaceTri Triangle.CalculateSurface(5, 6); // static

            // Console.WriteLine(quad.CalculateSurface());
            // Console.WriteLine(tri.CalculateSurface());

            Square square = new Square(3.8);
            // Console.WriteLine(square.CalculateSurface());

            Shape[] figures = 
            {
                quad,
                tri,
                square,
            };

            foreach (var f in figures)
            {
                Console.WriteLine(f.CalculateSurface());
            }
        }
    }
}
