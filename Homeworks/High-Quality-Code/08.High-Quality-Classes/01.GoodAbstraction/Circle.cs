using System;

namespace Abstraction
{
    public class Circle : IFigure
    {
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius { get; private set; }

        public double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
