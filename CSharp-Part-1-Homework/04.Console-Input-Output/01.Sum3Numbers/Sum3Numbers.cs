using System;
/// <summary>
/// 
/// Write a program that reads 3 real numbers from the console and prints their sum.
/// 
/// </summary>
class Sum3Numbers
{
    static void Main()
    {
        Console.Write("a =  ");
        double a;
        double b;
        double c;
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.WriteLine("You have entered invalid input!");
            Console.WriteLine("Please Enter Again!");
        };
        Console.Write("b =  ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.WriteLine("You have entered invalid input!");
            Console.WriteLine("Please Enter Again!");
        };
        Console.Write("c =  ");
        while (!double.TryParse(Console.ReadLine(), out c))
        {
            Console.WriteLine("You have entered invalid input!");
            Console.WriteLine("Please Enter Again!");
        };
        double sum = a + b + c;

        Console.WriteLine("Sum =  " + sum);
    }
}