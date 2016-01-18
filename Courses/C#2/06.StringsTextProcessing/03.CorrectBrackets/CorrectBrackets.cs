using System;
using System.Linq;
/// <summary>
/// 
/// Write a program to check if in a given expression the brackets are put correctly.
/// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
/// 
/// </summary>
class CorrectBrackets
{
    static void Main()
    {
        // Input
        Console.Write("Enter expression: ");
        string expression = Console.ReadLine();

        // Solution
        var checkStart = expression.Count(x => x == '(');
        var checkEnd = expression.Count(x => x == ')');

        // Output
        if (checkStart == checkEnd)
        {
            Console.WriteLine("Correct expression");
        }

        if (checkStart != checkEnd)
        {
            Console.WriteLine("Incorrect expression");
        }
    }
}