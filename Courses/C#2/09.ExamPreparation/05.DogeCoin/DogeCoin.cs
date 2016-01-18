using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DogeCoin
{
    static void Main()
    {
        int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int rows = size[0];
        int cols = size[1];
        int[,] field = new int[rows, cols];

        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            string[] coinsCoords = Console.ReadLine().Split(' ');
            int currentCoinsRow = int.Parse(coinsCoords[0]);
            int currentCoinsCol = int.Parse(coinsCoords[1]);

            field[currentCoinsRow, currentCoinsCol]++; 
        }

        int[,] dp = new int[rows, cols];

        for (int row = 0; row < dp.GetLength(0); row++)
        {
            for (int col = 0; col < dp.GetLength(1); col++)
            {
                int maxAbove = 0;
                int maxLeft = 0; 

                if (row - 1 >= 0)
                {
                    maxAbove = dp[row - 1, col];
                }

                if (col - 1 >= 0)
                {
                    maxLeft = dp[row, col - 1];
                }

                dp[row, col] = Math.Max(maxAbove, maxLeft) + field[row, col];
            }
        }

        Console.WriteLine(dp[rows - 1, cols - 1]);
    }
}