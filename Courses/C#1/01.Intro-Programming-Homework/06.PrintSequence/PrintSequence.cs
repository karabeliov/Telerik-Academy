using System;
/// <summary>
/// 
/// Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
/// 
/// </summary>
class PrintSequence
{
    static void Main()
    {
        for (int number = 2; number < 12; number++)
        {
            if (number % 2 == 0)
            {
                Console.Write("{0}, ", number);
            }
            else
            {
                if (number == 11)
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