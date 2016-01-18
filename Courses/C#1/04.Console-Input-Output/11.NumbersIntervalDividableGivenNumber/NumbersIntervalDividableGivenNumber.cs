using System;
/// <summary>
/// 
/// Write a program that reads two positive integer numbers and prints how many numbers p exist between them
/// such that the reminder of the division by 5 is 0.
/// 
/// </summary>
class NumbersIntervalDividableGivenNumber
{
    static void Main()
    {
        Console.Write("Enter start number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter end number: ");
        int end = int.Parse(Console.ReadLine());
        Console.Write("Enter dividable number: ");
        int dividable = int.Parse(Console.ReadLine());

        int counter = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % dividable == 0)
            {
                counter++;
            }
        }
        Console.WriteLine("Dividable by {0} = {1}", dividable, counter);
    }
}