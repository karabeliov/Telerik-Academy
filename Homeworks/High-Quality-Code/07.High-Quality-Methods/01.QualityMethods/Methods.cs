using System;

namespace Methods
{
    class Methods
    {
        enum PrintFormat
        {
            FloatingPoint,
            Percent,
            FloatLeft,
            FloatRight
        }

        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.Error.WriteLine("Sides should be positive.");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        static string DigitToText(int number)
        {
            string result = string.Empty;
            switch (number)
            {
                case 0: result = "zero"; 
                    break;
                case 1: result = "one";
                    break;
                case 2: result = "two";
                    break;
                case 3: result = "three";
                    break;
                case 4: result = "four";
                    break;
                case 5: result = "five";
                    break;
                case 6: result = "six";
                    break;
                case 7: result = "seven";
                    break;
                case 8: result = "eight";
                    break;
                case 9: result = "nine";
                    break;
                default:
                    result = "Invalid number!";
                    break;
            }

            return result;
        }

        static int FindMax(params int[] elements)
        {
            int[] numbers = new int[elements.Length];
            elements.CopyTo(numbers, 0);

            if (numbers == null || numbers.Length == 0)
            {
                Console.Error.WriteLine("Elements can't be null.");
                return -1;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[0])
                {
                    numbers[0] = numbers[i];
                }
            }

            return numbers[0];
        }

        static void PrintAsNumber(double number, PrintFormat format = PrintFormat.FloatLeft)
        {
            if (format == PrintFormat.FloatingPoint)
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == PrintFormat.Percent)
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == PrintFormat.FloatRight)
            {
                Console.WriteLine("{0,8}", number);
            }
            else if (format == PrintFormat.FloatLeft)
            {
                Console.WriteLine("{0}", number);
            }
        }

        static double CalcDistance(double x1, double x2, double y1, double y2, 
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            Console.WriteLine(DigitToText(5));
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, PrintFormat.FloatingPoint);
            PrintAsNumber(0.75, PrintFormat.Percent);
            PrintAsNumber(2.30, PrintFormat.FloatRight);

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, 3, -1, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
