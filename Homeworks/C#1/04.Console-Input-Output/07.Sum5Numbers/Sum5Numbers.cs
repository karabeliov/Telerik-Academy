using System;
/// <summary>
/// 
/// Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
/// 
/// </summary>
class Sum5Numbers
{
    static void Main()
    {
        Console.Write("Enter numbers: ");
        string input = Console.ReadLine();
        string[] fiveNumbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        double sum = 0;

        for (int i = 0; i < fiveNumbers.Length; i++)
        {
            sum += double.Parse(fiveNumbers[i]);
        }

        Console.WriteLine("Sum = " + sum);
    }
}