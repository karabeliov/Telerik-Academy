using System;
/// <summary>
/// 
/// Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
/// 
/// </summary>
class RandomizeTheNumbers1toN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool[] printed = new bool[number + 1];
        Random randomNumbers = new Random();

        for (int i = 0; i < number; i++)
        {
            int random = randomNumbers.Next(1, number + 1);
            if (!printed[random])
            {
                Console.Write(random + " ");
                printed[random] = true;
            }
            else
            {
                i--;
            }
        }
        Console.WriteLine();
    }
}