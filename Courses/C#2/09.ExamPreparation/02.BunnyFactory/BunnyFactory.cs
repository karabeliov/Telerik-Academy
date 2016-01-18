using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class BunnyFactory
{
    static void Main()
    {
        // Input
        var cages = Input();

        // Solution
        for (int step = 1; true; step++) // true is not necessary
        {
            if (cages.Count < step)
            {
                break;
            }

            int cagesCount = SumListInRange(cages, 0, step - 1);

            if (cages.Count < step + cagesCount)
            {
                break;
            }

            var sum = SumListInRange(cages, step, cagesCount + step - 1);
            var product = ProductListInRange(cages, step, cagesCount + step - 1);
            StringBuilder result = new StringBuilder();

            result.Append(sum);
            result.Append(product);

            for (int i = cagesCount + step; i < cages.Count; i++)
            {
                result.Append(cages[i]);
            }

            cages.Clear();
            foreach (var symbol in result.ToString())
            {
                if (symbol != '0' && symbol != '1')
                {
                    cages.Add(symbol - '0');
                }
            }
        }

        // Output
        Console.WriteLine(string.Join(" ", cages));
    }

    private static BigInteger ProductListInRange(List<int> cages, int start, int end)
    {
        BigInteger product = 1;
        for (int i = start; i <= end; i++)
        {
            product *= cages[i];
        }

        return product;
    }

    private static int SumListInRange(List<int> cages, int start, int end)
    {
        int sum = 0;
        for (int i = start; i <= end; i++)
        {
            sum += cages[i];
        }

        return sum;
    }

    private static List<int> Input()
    {
        List<int> cages = new List<int>(101); // enter capacity
        while (true)
        {
            string line = Console.ReadLine();

            if (line == "END")
            {
                break;
            }

            int cage = int.Parse(line);
            cages.Add(cage);
        }

        return cages;
    }
}