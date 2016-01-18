using System;
/// <summary>
/// 
/// Write a program that finds the biggest of five numbers by using only five if statements.
/// 
/// </summary>
class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());
        double biggestAB;
        double biggestCD;
        double biggest;

        if (a > b)
        {
            biggestAB = a;
        }
        else
        {
            biggestAB = b;
        }

        if (c > d)
        {
            biggestCD = c;
        }
        else
        {
            biggestCD = d;
        }

        if (biggestAB > biggestCD)
        {
            biggest = biggestAB;
        }
        else
        {
            biggest = biggestCD;
        }

        if (biggest > e)
        {
            Console.WriteLine("Biggest number: " + biggest);
        }
        else
        {
            biggest = e;
            Console.WriteLine("Biggest number: " + biggest);
        }
    }
}