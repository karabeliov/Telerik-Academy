using System;
using System.Collections.Generic;
/// <summary>
/// 
/// Write a method that calculates the number of workdays between today and given date, passed as parameter.
/// Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
/// 
/// </summary>
class Workdays
{
    static void Main()
    {
        // Input
        Console.Write("Enter date(d.m.y): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        DateTime today = DateTime.Today;

        // Solution
        List<DateTime> holidays = new List<DateTime>();

        holidays.Add(DateTime.Parse("6.3.2015")); // telerik examp
        //holidays.Add(DateTime.Parse("5.3.2015")); // telerik examp
        //holidays.Add(DateTime.Parse("31.12.2015")); // new year

        int days = 0;
        int count = 0;
        for (DateTime i = today; i <= date; i = i.AddDays(1))
        {
            if (DayOfWeek.Saturday == i.DayOfWeek || DayOfWeek.Sunday == i.DayOfWeek) // check for weekdays
            {
                continue;
            }
            else
            {
                if (holidays[count].DayOfWeek != i.DayOfWeek) // check for holidays
                {
                    days++; // count workdays
                }
            }

            if (count < holidays.Count - 1) 
            {
                count++;
            }
        }

        // Output
        Console.WriteLine(days);
    }
}