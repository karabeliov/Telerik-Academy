namespace tastFrom1to4
{
    using System;

    public class tastFrom1to4
    {
        static void Main()
        {
            Point3D point1 = new Point3D(4, 5.4, 6);
            Point3D point2 = new Point3D(5, 5.4, 6);

            // Console.WriteLine(point1
            // Console.WriteLine(Point3D.PointO); // pring point O

            double distance = Distance.CalculateDistance(point1, point2);

            // Console.WriteLine("Distance between this two points: {0}", distance);

            Path firstPath = new Path(); // add path
            firstPath.AddPoint(point1);
            firstPath.AddPoint(point2);

            PathStorage.SavePath(firstPath); // save in text file

            string loadPath = PathStorage.LoadPath(); // load from text file

            Console.WriteLine(loadPath);
        }
    }
}
