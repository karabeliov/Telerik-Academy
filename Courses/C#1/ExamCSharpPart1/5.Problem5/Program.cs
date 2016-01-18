using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        string bits = string.Empty;
        // Input
        for (int row = 0; row < size; row++)
        {
            int number = int.Parse(Console.ReadLine());
            bits += Convert.ToString(number, 2).PadLeft(30, '0');
        }
        // Solution      
        // Count Zero
        var longest0 = (from s in Regex.Split(bits, "[^0]+")
                        orderby s.Length descending
                        select s.Length).Take(1);

        Console.WriteLine(longest0.ToArray()[0]);
        // Count One
        var longest1 = (from s in Regex.Split(bits, "[^1]+")
                        orderby s.Length descending
                        select s.Length).Take(1);

        Console.WriteLine(longest1.ToArray()[0]);
    }
}