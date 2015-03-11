using System;
/// <summary>
/// 
/// Write a program that finds the biggest of three numbers.
/// 
/// </summary>
class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double biggest;

        if (a > b)
        {
            biggest = a;           
        }
        else
        {
            biggest = b;
        }

        if (biggest > c)
        {
            Console.WriteLine("The biggest number: " + biggest);
        }
        else
        {
            Console.WriteLine("The biggest number: " + c);
        }
    }
}