using System;
/// <summary>
/// 
/// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
/// 
/// </summary>
class MaximalSum
{
    static void Main()
    {
        // Input
        Console.Write("Enter size of matrix rows(N): ");
        int rowSize = int.Parse(Console.ReadLine());

        Console.Write("Enter size of matrix cols(M): ");
        int colSize = int.Parse(Console.ReadLine());

        if (rowSize < 3 || colSize < 3)
        {
            Console.WriteLine();
            Console.WriteLine("The matrix is to small!");
            return;
        }
        int[,] matrix = new int[rowSize, colSize];
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Matrix[{0}, {1}] = ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        // Solution

        int bestSum = int.MinValue;

        // Platform
        int height = 3;
        int width = 3;

        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - height + 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - width + 1; col++)
            {
                int currentSum = 0;
                for (int platformRow = row; platformRow < row + height; platformRow++)
                {
                    for (int platformCol = col; platformCol < col + width; platformCol++)
                    {
                        currentSum += matrix[platformRow, platformCol];
                    }
                }

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // Output
        PrintMatrix(matrix);
        Console.WriteLine();
        Console.WriteLine("The Best Platform is:");
        Console.WriteLine();
        for (int platformRow = bestRow; platformRow < bestRow + height; platformRow++)
        {
            for (int platformCol = bestCol; platformCol < bestCol + width; platformCol++)
            {
                Console.Write(" {0} ", matrix[platformRow, platformCol]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("The sum of this platform is: " + bestSum);
    }

    private static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-3}", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}