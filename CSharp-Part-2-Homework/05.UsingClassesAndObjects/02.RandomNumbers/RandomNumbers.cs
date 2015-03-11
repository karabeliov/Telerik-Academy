using System;
using System.Collections.Generic;
/// <summary>
/// 
/// Write a program that generates and prints to the console 10 random values in the range [100, 200].
/// 
/// </summary>
class RandomNumbers
{
    static void Main()
    {
        Random randomGenerator = new Random();

        Console.WriteLine("This numbers is random generated in the range[100, 200]: ");
        HashSet<int> randomNumbers = new HashSet<int>();
        while (true)
        {
            randomNumbers.Add(randomGenerator.Next(100, 201));

            if (randomNumbers.Count == 10)
            {
                break;
            }
        }

        Console.Write(string.Join(", ", randomNumbers));
        Console.WriteLine();
    }
}