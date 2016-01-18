using System;
/// <summary>
/// 
/// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
/// Use only one loop. Print the result with 5 digits after the decimal point.
/// 
/// </summary>
class CalculateXN
{
    static void Main()
    {
        Console.Write("Write n =  ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Write x =  ");
        double x = int.Parse(Console.ReadLine());
        double s = 1;
        double factorial = 1;
        double tempDelitel = 1.00;
        //sum S = 1 + 1!/x + 2!/x2 + … + n!/xn
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            tempDelitel *= x;
            s += (factorial / tempDelitel);
        }
        Console.WriteLine("S =  {0:f5}", s);
    }
}