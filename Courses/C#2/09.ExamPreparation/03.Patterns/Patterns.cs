using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Patterns
{
    static bool foundPatter;
    static void Main()
    {
        // Input
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        FullMatrix(matrix);

        // Solution
        long sumDiagona = SumDiagonal(matrix);

        long sumPattertn = SearchSumPlatform(matrix);

        // Output
        if (foundPatter)
        {
            Console.WriteLine("YES {0}", sumPattertn);
        }
        else
        {
            Console.WriteLine("NO {0}", sumDiagona);
        }
    }

    private static long SumDiagonal(int[,] matrix)
    {
        long sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }

        return sum;
    }

    private static long SearchSumPlatform(int[,] matrix)
    {
        var pattern = new bool[,]
        {
            {true, true, true, false, false},
            {false, false, true, false, false},
            {false, false, true, true, true},
        };

        long maxSum = long.MinValue;
        foundPatter = false;
        for (int row = 0; row <= matrix.GetLength(0) - pattern.GetLength(0); row++) // matrix
        {
            for (int col = 0; col <= matrix.GetLength(1) - pattern.GetLength(1); col++)
            {
                var numbersInPattern = new List<int>(pattern.GetLength(0));

                for (int patternRow = 0; patternRow < pattern.GetLength(0); patternRow++) // pattern
                {
                    for (int patternCol = 0; patternCol < pattern.GetLength(1); patternCol++)
                    {
                        var x = row + patternRow;
                        var y = col + patternCol;

                        if (pattern[patternRow, patternCol])
                        {
                            numbersInPattern.Add(matrix[x,y]);
                        }
                    }
                }

                bool found = true;
                for (int index = 1; index < numbersInPattern.Count; index++) // numbers in pattern
                {
                    if (numbersInPattern[index - 1] != numbersInPattern[index] - 1)
                    {
                        found = false;
                        break; 
                    }

                    if (found)
                    {
                        foundPatter = true;
                        long sum = 0;

                        foreach (var number in numbersInPattern)
                        {
                            sum += number;
                        }

                        // maxSum = Math.Max(maxSum, sum);
                        if (sum > maxSum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            }
        }

        return maxSum;
    }

    private static void FullMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string rows = Console.ReadLine();
            string[] numbers = rows.Split(' ');

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(numbers[col]);
            }
        }
    }
}