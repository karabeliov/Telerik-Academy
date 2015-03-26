namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        private double width;
        private double height;

        public static double CalculateSurface(double width, double height)
        {
            return width * height;
        }
    }
}
