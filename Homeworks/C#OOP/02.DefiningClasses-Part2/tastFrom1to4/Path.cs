namespace tastFrom1to4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Path
    {
        private List<Point3D> path = new List<Point3D>();

        public void AddPoint(Point3D point1)
        {
            path.Add(point1);
        }

        public List<Point3D> GetListPath()
        {
            return path;
        }
    }
}
