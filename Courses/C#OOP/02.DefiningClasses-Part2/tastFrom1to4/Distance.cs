namespace tastFrom1to4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Distance
    {
        public static double CalculateDistance(Point3D point1, Point3D point2)
        {
            double distance = Math.Sqrt((point1.PointX - point2.PointX) * (point1.PointX - point2.PointX) +
                                        (point1.PointY - point2.PointY) * (point1.PointY - point2.PointY) +
                                        (point1.PointZ - point2.PointZ) * (point1.PointZ - point2.PointZ));

            return distance;
        }
    }
}
