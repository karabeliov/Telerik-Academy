using System;
/// <summary>
/// 
/// Write a program that enters 3 integers n, min and max (min = max) and prints n random numbers in the range [min...max].
/// 
/// </summary>
class RandomNumbersGivenRange
{
    static void Main()
    {
        Console.Write("Enter hom many numbers to generated: ");
        int numbers = int.Parse(Console.ReadLine());
        Console.Write("Enter minimum number: ");
        int minimum = int.Parse(Console.ReadLine());
        Console.Write("Enter maximum number: ");
        int maximum = int.Parse(Console.ReadLine());
        Random randomNumbers = new Random();

        for (int i = 0; i < numbers; i++)
        {
            Console.Write(randomNumbers.Next(minimum, maximum + 1) + " ");
        }
        Console.WriteLine();
    }
}