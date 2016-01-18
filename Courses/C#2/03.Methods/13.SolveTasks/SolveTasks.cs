using System;
using System.Linq;
/// <summary>
/// 
/// Write a program that can solve these tasks:
///  - Reverses the digits of a number
///  - Calculates the average of a sequence of integers
///  - Solves a linear equation a * x + b = 0
/// Create appropriate methods.
/// Provide a simple text-based menu for the user to choose which task to solve.
/// Validate the input data:
///  - The decimal number should be non-negative
///  - The sequence should not be empty
///  - a should not be equal to 0
/// 
/// </summary>
class SolveTasks
{
    static void Main()
    {
        // Menu
        Console.WriteLine("TASK 1: Reverses the digits of a number!");
        Console.WriteLine("TASK 2: Calculates the average of a sequence of integers!");
        Console.WriteLine("TASK 3: Solves a linear equation a * x + b = 0!");
        Console.WriteLine();
        Console.Write("Choose task(1, 2 or 3): ");
        int? task = null;

        try
        {
            task = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine();
            Console.WriteLine("Error Invalide Input!!!!");
            return;
        }
        
        Console.Clear();
        Console.WriteLine();

        switch (task)
        {
            // Solve Task 1
            case 1:
                Console.Write("Enter number to revers the digits: ");
                string number = Console.ReadLine();

                // Validate the input
                for (int index = 0; index < number.Length; index++)
                {
                    if (char.IsDigit(number, index))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("The input is not correct!!!");
                        Console.WriteLine("Please input positive number!");
                        Console.WriteLine();
                        Main();
                    }
                }

                char[] reversed = number.Reverse().ToArray();
                
                // Output 
                Console.Write("Reverse digits is: ");
                foreach (var element in reversed)
                {
                    Console.Write(element);
                }

                Console.WriteLine();

                break;
            // Solve Task 2
            case 2:

                try
                {
                    Console.Write("Enter size of sequence: ");
                    int size = int.Parse(Console.ReadLine());

                    int[] sequence = new int[size];

                    for (int index = 0; index < sequence.Length; index++)
                    {
                        Console.Write("Enter integer number on index[{0}]: ", index);
                        sequence[index] = int.Parse(Console.ReadLine());
                    }

                    double aver = sequence.Average();
                    Console.WriteLine();
                    Console.WriteLine("Average of a sequence is {0}", aver);
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error Invalide Input!!!!");
                    Main();
                }

                break;
            // Solve Task 3
            case 3:
                try
                {
                    Console.Write("Enter a = ");
                    double a = int.Parse(Console.ReadLine());

                    // Validate the input
                    if (a == 0)
                    {
                        Console.WriteLine("Error \"a\" can not be equal to zero!");
                        Main();
                    }
                    Console.Write("Enter b = ");
                    double b = int.Parse(Console.ReadLine());
                    double x = LinearEquation(a, b);
                    Console.WriteLine();

                    Console.WriteLine("x = {0}", x);
                    Console.WriteLine("{0} * {1} + {2} = 0", a, x, b);
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error Invalide Input!!!!");
                    Main();
                }

                
                break;
            default: Console.WriteLine("Error wrong choice!");
                Main();
                break;
        }
    }

    private static double LinearEquation(double a, double b)
    {
        double x = -b / a;
        return x;
    }
}