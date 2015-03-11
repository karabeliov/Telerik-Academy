using System;
/// <summary>
/// 
/// Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
/// 
/// </summary>
class PrintLongSequence
{
    static void Main()
    {
        for (int number = 2; number < 1002; number++)
        {
            if (number % 2 == 0)
            {
                Console.Write("{0}, ", number);
            }
            else
            {
                if (number == 1001)
                {
                    Console.Write("{0} ", number - number * 2);
                }
                else
                {
                    Console.Write("{0}, ", number - (number * 2));
                }
            }
        }
        Console.WriteLine();
    }
}