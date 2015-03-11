using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

class HelpDoge
{
    static int finalRow, finalCol;
    static void Main()
    {
        // Input
        BigInteger[,] field = Input();
        
        // Solution
        BigInteger ways = CountWays(field);

        // Output
        Console.WriteLine(ways);
    }

    private static BigInteger CountWays(BigInteger[,] field)
    {
        for (int row = 0; row < field.GetLength(0); row++)
        {
            for (int col = 0; col < field.GetLength(1); col++)
            {
                if (row == 0 && col == 0)
                {
                    field[0, 0] = 1;
                    continue;
                }

                if (field[row, col] == -1)
                {
                    field[row, col] = 0;
                    continue;
                }

                if (row == 0)
                {
                    field[0, col] = field[0, col - 1];
                    continue;
                }

                if (col == 0)
                {
                    field[row, 0] = field[row - 1, 0];
                    continue;
                }

                field[row, col] = field[row - 1, col] + field[row, col - 1];
            }
        }

        return field[finalRow, finalCol];
    }

    private static BigInteger[,] Input()
    {
        string input = Console.ReadLine();
        string[] line = input.Split(' ');

        int rowField = int.Parse(line[0]);
        int colField = int.Parse(line[1]);

        input = Console.ReadLine();
        line = input.Split(' ');

        finalRow = int.Parse(line[0]);
        finalCol = int.Parse(line[1]);

        int enemy = int.Parse(Console.ReadLine());

        BigInteger[,] field = new BigInteger[rowField, colField];

        for (int i = 0; i < enemy; i++)
        {
            input = Console.ReadLine();
            line = input.Split(' ');

            int eRow = int.Parse(line[0]);
            int eCol = int.Parse(line[1]);

            field[eRow, eCol] = -1;
        }

        return field;
    }
}