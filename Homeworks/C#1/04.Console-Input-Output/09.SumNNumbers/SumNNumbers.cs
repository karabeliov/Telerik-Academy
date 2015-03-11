using System;
/// <summary>
/// 
/// Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
/// 
/// </summary>
class SumNNumbers
{
    static void Main()
    {
        Console.Write("Enter how many number you want to sum: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;

        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number; 
        }

        Console.WriteLine("Sum = " + sum);
    }
}