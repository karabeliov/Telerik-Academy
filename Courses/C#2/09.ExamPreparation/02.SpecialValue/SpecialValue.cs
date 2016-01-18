using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SpecialValue
{
    static void Main()
    {
        // Input
        int lines = int.Parse(Console.ReadLine());

        int[][] field = new int[lines][]; // Jagged Array

        ReadDate(field);

        // Solution
        bool[][] used = new bool[lines][];

        for (int i = 0; i < lines; i++)
        {
            used[i] = new bool[field[i].Length];
        }

        long maxValue = long.MinValue;
        for (int col = 0; col < field[0].Length; col++)
        {
            long specialValue = FineValue(field, used, col);

            if (specialValue > maxValue)
            {
                maxValue = specialValue;
            }
        }

        // Output
        Console.WriteLine(maxValue);
    }

    private static long FineValue(int[][] field, bool[][] used, int col)
    {
        long result = 0;
        int currenRow = 0;

        while (true)
        {
            result++;

            if (used[currenRow][col])
            {
                return long.MinValue;
            }

            if (field[currenRow][col] < 0)
            {
                result += Math.Abs(field[currenRow][col]);
                return result;
            }

            int nextColumn = field[currenRow][col];
            used[currenRow][col] = true;
            col = nextColumn;

            currenRow++;

            if (currenRow == field.GetLength(0))
            {
                currenRow = 0;
            }
        }
    }


    static int[][] ReadDate(int[][] field)
    {
        for (int i = 0; i < field.GetLength(0); i++)
        {
            string[] currentLine = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            field[i] = new int[currentLine.Length];

            for (int j = 0; j < currentLine.Length; j++)
            {
                field[i][j] = int.Parse(currentLine[j]);
            }
        }

        return field;
    }
}