using System;
/// <summary>
/// 
/// Write an expression that checks for given integer if its third digit from right-to-left is 7.
/// 
/// </summary>
class ThirdDigit7
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isSeven = false;

        number = (number / 100) % 10;

        if (number == 7)
        {
            Console.WriteLine(!isSeven);
        }
        else
        {
            Console.WriteLine(isSeven);
        }
    }
}