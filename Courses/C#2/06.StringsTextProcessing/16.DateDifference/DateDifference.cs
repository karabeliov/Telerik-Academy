using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/// <summary>
/// 
/// Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
/// 
/// </summary>
class DateDifference
{
    static void Main()
    {
        // Input
        Console.Write("Enter the first date: ");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the second date: ");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        // Solution
        TimeSpan distance = firstDate - secondDate;

        // Output
        Console.WriteLine("Distance: {0}", Math.Abs(distance.Days));
    }
}