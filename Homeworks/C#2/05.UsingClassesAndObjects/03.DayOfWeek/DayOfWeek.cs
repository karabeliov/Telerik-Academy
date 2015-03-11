using System;
/// <summary>
/// 
/// Write a program that prints to the console which day of the week is today.
/// Use System.DateTime.
/// 
/// </summary>
class DayOfWeek
{
    static void Main()
    {
        var today = DateTime.Now.DayOfWeek;

        Console.WriteLine("Today is {0}", today);
    }
}