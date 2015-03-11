using System;
using System.Linq;
/// <summary>
/// 
/// Write a program that finds the maximal sequence of equal elements in an array.
/// Example:
/// input	                      | result
/// 2, 1, 1, 2, 3, 3, 2, 2, 2, 1  |	2, 2, 2
/// 
/// </summary>
class MaximalSequence
{
    static void Main()
    {
        // Input
        Console.Write("Enter sequence: ");
        string input = Console.ReadLine();
        string[] array = input.Split(new char[] {',', ' ', '\t', '\n'}, StringSplitOptions.RemoveEmptyEntries);

        // Solution
        string[] max = array.Select((n, i) => new { Value = n, Index = i })
            .OrderBy(s => s.Value)
            .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
            .GroupBy(s => new { s.Value, s.Diff })
            .OrderByDescending(g => g.Count())
            .First()
            .Select(f => f.Value).ToArray();

        // Output
        Console.Write("Maximal sequence of equal elements is: ");
        Console.Write(string.Join(", ", max));
        Console.WriteLine();

    }
}