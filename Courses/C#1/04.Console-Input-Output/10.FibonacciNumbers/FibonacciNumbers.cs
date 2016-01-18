using System;
/// <summary>
/// 
/// Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
/// (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
/// 
/// </summary>
class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Write number:  ");
        int n = int.Parse(Console.ReadLine());
        decimal firstNumber = 0;
        decimal secondNumber = 1;
        decimal sum = 0;

        if (n != 1)
        {
            Console.Write("{0}", firstNumber);
            Console.Write(", {0}", secondNumber);
            for (int i = 1; i < n - 1; i++)
            {
                sum = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = sum;
                Console.Write(", {0}", sum);
            }
            Console.WriteLine();
        }
        else
        {
            Console.Write(firstNumber);
            Console.WriteLine();
        }
    }
}