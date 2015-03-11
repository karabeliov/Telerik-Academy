using System;
/// <summary>
/// 
/// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
/// 
/// </summary>
class DivideBy7And5
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isDivided = false;

        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine(!isDivided);
        }
        else
        {
            Console.WriteLine(isDivided);
        }
    }
}