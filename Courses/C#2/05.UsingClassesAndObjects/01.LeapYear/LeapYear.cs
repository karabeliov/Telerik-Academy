using System;
/// <summary>
/// 
/// https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/05.%20Using%20Classes%20and%20Objects/README.md for example
/// Write a program that reads a year from the console and checks whether it is a leap one.
/// Use System.DateTime.
/// 
/// </summary>
class LeapYear
{
    static void Main()
    {
        try
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            bool isLeap = DateTime.IsLeapYear(year);

            if (isLeap)
            {
                Console.WriteLine("This year is Leap!");
            }
            else
            {
                Console.WriteLine("This year us NOT Leap!");
            }
        }
        catch (Exception)
        {
            Console.WriteLine();
            Console.WriteLine("Error! You put uncorrect input.");
        }

    }
}