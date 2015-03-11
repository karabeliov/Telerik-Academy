using System;
/// <summary>
/// 
/// Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7,
/// on a single line, separated by a space.
/// 
/// </summary>
class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());

        for (int number = 1; number <= input; number++)
        {
            if (number % 3 != 0 && number % 7 != 0)
            {
                Console.Write("{0} ", number);
            }
        }
        Console.WriteLine();
    }
}