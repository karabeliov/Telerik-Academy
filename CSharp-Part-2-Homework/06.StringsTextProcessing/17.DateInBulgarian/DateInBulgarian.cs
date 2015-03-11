using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;
/// <summary>
/// 
/// Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
/// and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
/// 
/// </summary>
class DateInBulgarian
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");    
        // Input
        Console.Write("Enter date and time in this format\n[ day.month.year hour:minute:second ]:  ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        // Solution
        date = date.AddHours(6).AddMinutes(30);

        // Output
        Console.WriteLine();
        Console.WriteLine("After 6 hourse and 30 minutes the time and date is will be:");
        Console.WriteLine("{0} and day of week is {1}", date, date.DayOfWeek);
    }
}