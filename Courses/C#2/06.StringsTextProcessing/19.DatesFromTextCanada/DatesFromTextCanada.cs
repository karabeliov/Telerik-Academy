using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
/// <summary>
/// 
/// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
/// Display them in the standard date format for Canada.
/// 
/// </summary>
class DatesFromTextCanada
{
    static void Main()
    {
        // Input
        Console.Write("Enter text with dates: ");
        string dates = Console.ReadLine();

        // Solution and Output
        DateTime date;
        foreach (Match item in Regex.Matches(dates, @"\b[0-9]{1,2}.[0-9]{1,2}.[0-9]{2,4}"))
        {          
            if (DateTime.TryParseExact(item.Value, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine("Format date in Canada is " + date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}