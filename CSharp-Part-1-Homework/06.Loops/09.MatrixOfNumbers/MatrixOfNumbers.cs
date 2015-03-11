using System;
/// <summary>
/// 
/// Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
/// 
/// </summary>
class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        byte n = byte.Parse(Console.ReadLine());
        byte endLine = n;

        Console.WriteLine();
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i);
            for (int j = i + 1; j <= endLine; j++)
            {
                Console.Write(j);
            }
            endLine++;
            Console.WriteLine();
        }
    }
}