using System;

namespace CohesionAndCoupling
{
    public class Examples
    {
        static void Main()
        {
            Console.WriteLine(FileInfo.GetFileExtension("example"));
            Console.WriteLine(FileInfo.GetFileExtension("example.pdf"));
            Console.WriteLine(FileInfo.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileInfo.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileInfo.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileInfo.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Calculate.Distance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Calculate.Distance3D(5, 2, -1, 3, -6, 4));

            Console.WriteLine("Volume = {0:f2}", Calculate.Volume(3, 4, 5));
            Console.WriteLine("Diagonal XYZ = {0:f2}", Calculate.DiagonalXYZ(3, 4, 5));
            Console.WriteLine("Diagonal XY = {0:f2}", Calculate.DiagonalXY(3, 4));
            Console.WriteLine("Diagonal XZ = {0:f2}", Calculate.DiagonalXZ(3, 5));
            Console.WriteLine("Diagonal YZ = {0:f2}", Calculate.DiagonalYZ(4, 5));
        }
    }
}
