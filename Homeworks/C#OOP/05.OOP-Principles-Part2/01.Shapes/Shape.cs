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

        public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public Shape(double side)
        {
            this.Width = side;
            this.Height = Width;
        }

        public double Width
        {
            get { return width; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Width cannot be negative number");
                }

                width = value; 
            }
        }

        public double Height
        {
            get { return height; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height cannot be negative number");
                }

                height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
