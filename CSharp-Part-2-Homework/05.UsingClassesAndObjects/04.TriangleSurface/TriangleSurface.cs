using System;
/// <summary>
/// 
/// Write methods that calculate the surface of a triangle by given:
///   - Side and an altitude to it;
///   - Three sides;
///   - Two sides and an angle between them;
/// 
/// </summary>
class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Method 1: Side and an altitude to it");
        Console.WriteLine("Method 2: Three sides");
        Console.WriteLine("Method 3: Two sides and an angle between them");
        Console.WriteLine();
        Console.Write("Choise method to calculate between(1, 2 or 3): ");
        int choise = int.Parse(Console.ReadLine());
        Console.Clear();

        if (choise == 1)
        {
            Console.Write("Enter side = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter altitude = ");
            double hA = double.Parse(Console.ReadLine());
            double surface = SurfaceTriangle(a, hA);

            Console.WriteLine("Area is " + surface);
        }
        else if (choise == 2)
        {
            Console.Write("Enter side a = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter side b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter side c = ");
            double c = double.Parse(Console.ReadLine());

            // Validation
            if (a + b < c)
            {
                Console.WriteLine("Your 3 side lengths are invalid.");
                Console.WriteLine("A + B > C");
                return;
            }
            else if (b + c < a)
            {
                Console.WriteLine("Your 3 side lengths are invalid.");
                Console.WriteLine("B + C > A");
                return;
            }
            else if (a + c < b)
            {
                Console.WriteLine("Your 3 side lengths are invalid.");
                Console.WriteLine("A + C > B");
                return;
            }

            double surface = SurfaceTriangle(a, b, c);

            Console.WriteLine("Area is " + surface);
        }
        else if (choise == 3)
        {
            Console.Write("Enter first side = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter second side = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter angle between them = ");
            double angle = double.Parse(Console.ReadLine());

            double surface = SurfaceTriangleAngle(a, b, angle);

            Console.WriteLine("Area is {0:f2}", surface);
        }
        else
        {
            Console.WriteLine("Wrong choise! Choise between(1,2 or 3)");
        }
    }

    private static double SurfaceTriangleAngle(double a, double b, double angle)
    {
        double area = 0.5 * a * b * Math.Sin(angle);
        area = Math.Abs(area);
        return area;
    }

    private static double SurfaceTriangle(double a, double b, double c)
    {
        double s = (a + b + c) / 2.0;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        return area;
    }

    private static double SurfaceTriangle(double a, double hA)
    {
        double area = (a * hA) / 2.0;
        return area;
    }
}