namespace Game.Common
{
    using System;

    public class Point
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Point(int x = 0, int y = 0)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
