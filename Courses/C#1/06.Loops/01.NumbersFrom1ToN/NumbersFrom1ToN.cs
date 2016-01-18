using System;
/// <summary>
/// 
/// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
/// 
/// </summary>
class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        for (int number = 1; number <= input; number++)
        {
            Console.Write("{0} ", number);
        }
        Console.WriteLine();
    }
}