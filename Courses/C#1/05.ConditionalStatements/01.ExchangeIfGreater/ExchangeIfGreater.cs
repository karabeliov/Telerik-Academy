using System;
/// <summary>
/// 
/// Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one.
/// As a result print the values a and b, separated by a space.
/// 
/// </summary>
    class ExchangeIfGreater
    {
        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Result = ");
            if (a > b)
            {
                Console.Write(b + " ");
                Console.WriteLine(a);
            }
            else
            {
                Console.Write(a + " ");
                Console.WriteLine(b);
            }
        }
    }