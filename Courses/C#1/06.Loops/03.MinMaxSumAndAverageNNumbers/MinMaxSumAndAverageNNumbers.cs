using System;
/// <summary>
/// 
/// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
/// the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
/// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
/// The output is like in the examples below.
/// 
/// </summary>
class MinMaxSumAndAverageNNumbers
{
    static void Main()
    {
        Console.Write("How many numbers: ");
        byte n = byte.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        double average = 0;
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
            sum += number;
        }

        average = (double)sum / n;
        Console.WriteLine("min = " + min);
        Console.WriteLine("max = " + max);
        Console.WriteLine("sum = " + sum);
        Console.WriteLine("average = {0:f2}", average);
    }
}