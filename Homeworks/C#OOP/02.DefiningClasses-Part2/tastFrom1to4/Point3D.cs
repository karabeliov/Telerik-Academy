namespace tastFrom1to4
{
    public struct Point3D
    {

        private double height;
        private double width;
        private double depth;
        private static readonly Point3D O = new Point3D(0, 0, 0);
        public static Point3D PointO
        {
            get { return O; }
        }


        public Point3D(double X, double Y, double Z)
        {
            height = X;
            width = Y;
            depth = Z;
        }

        public double PointX
        {
            get { return height; }
            set { height = value; }
        }

        public double PointY
        {
            get { return width; }
            set { width = value; }
        }

        public double PointZ
        {
            get { return depth; }
            set { width = value; }
        }

        public override string ToString()
        {
            return string.Format("height = {0}\nwidth = {1}\ndepth = {2}", height, width, depth);
        }
    }
}
