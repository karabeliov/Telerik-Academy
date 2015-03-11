using System;
/// <summary>
/// 
/// Write an expression that checks if given integer is odd or even.
/// 
/// </summary>
/// 
class OddEvenIntegers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isOdd = false;

        if (number % 2 == 0)
        {
            Console.WriteLine(isOdd);
        }
        else
        {
            Console.WriteLine(!isOdd);
        }
    }
}