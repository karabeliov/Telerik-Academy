namespace _01.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Square : Shape
    {
        public Square(double side)
            : base(side)
        {
        }

        public override double CalculateSurface()
        {
            return base.Width * base.Height;
        }
    }
}
