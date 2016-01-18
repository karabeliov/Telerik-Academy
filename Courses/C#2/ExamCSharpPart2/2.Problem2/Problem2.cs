using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
class Problem2
{
    static List<long> numbers = new List<long>();
    static void Main()
    {
        // Input
        numbers = Input();
        BigInteger sumResult = 0;
        
        for (int i = 1; i < numbers.Count; i++)
        {
            BigInteger diff = Math.Abs(numbers[i - 1] - numbers[i]);

            if (diff % 2 == 0 && i + 1 < numbers.Count)
            {
                i += 1;
            }

            if (diff % 2 != 0)
            {
                sumResult += diff;
            }
        }

        // Output
        Console.WriteLine(sumResult);
    }

    private static List<long> Input()
    {
        string[] input = Console.ReadLine().Split(' ');

        numbers = new List<long>();

        foreach (var n in input)
        {
            numbers.Add(int.Parse(n));
        }

        return numbers;
    }
}