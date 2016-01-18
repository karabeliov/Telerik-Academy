using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSizeInCSharp
{
    class ClassSize
    {
        static void Main()
        {
            double width = 10.5;
            double height = 5.5;
            double angle = 35;

            Size triangle = new Size(width, height);
            Console.WriteLine("This figure has width {0} and height {1}", triangle.Width, triangle.Height);

            triangle = Size.GetRotatedSize(triangle, angle);
            Console.WriteLine("After rotated figure has width {0} and height {1}", triangle.Width, triangle.Height);
        }
    }

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; private set; }
        public double Height { get; private set; }

        public static Size GetRotatedSize(Size size, double angle)
        {
            double cos = Math.Abs(Math.Cos(angle));
            double sin = Math.Abs(Math.Sin(angle));
            double width = (cos * size.Width) + (sin * size.Height);
            double height = (sin * size.Width) + (cos * size.Height);
            Size sizeOfFigure = new Size(width, height);

            return sizeOfFigure;
        }
    }
}
