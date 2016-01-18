using System;
/// <summary>
/// 
/// Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.
/// 
/// </summary>
class LargestAreaMatrix
{
    static int[,] matrix;
    static int bestLength = 0, bestNumber = 0;
    static int currentLength = 0, currentNumber = 0;

    static void Main()
    {
        // Input

        //// Test for users
        //Console.Write("Enter size of Matrix row: ");
        //int row = int.Parse(Console.ReadLine());
        //Console.Write("Enter size of Matrix col: ");
        //int col = int.Parse(Console.ReadLine());
        //matrix = new int[row, col];

        //for (int i = 0; i < matrix.GetLength(0); i++)
        //{
        //    for (int j = 0; j < matrix.GetLength(1); j++)
        //    {
        //        Console.Write("Enter Array[{0}, {1}] = ", i, j);
        //        matrix[i, j] = int.Parse(Console.ReadLine());
        //    }
        //}

        // Test for developers
        matrix = new int[5, 6]  // size matrix
        { 
            {1, 3, 2, 2, 2, 4},
            {3, 3, 3, 2, 4, 4},
            {4, 3, 1, 2, 3, 3},
            {4, 3, 1, 3, 3, 1},
            {4, 3, 3, 3, 1, 1}      
        };

        // Solution
        PrintMatrix(matrix);
        FindBestAreaLenght(matrix);


        // Output
        Console.WriteLine("Largest area in matrix is number {0} -> {1} times\n", bestNumber, bestLength);
    }

    private static void FindBestAreaLenght(int[,] matrix)
    {
        bestLength = 0;
        bestNumber = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                currentNumber = matrix[row, col];
                currentLength = 0;

                InRange(row, col);

                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestNumber = currentNumber;
                }
            }
        }

    }


    static void InRange(int row, int col) 
    {
        bool rowInRange = row < 0 || row >= matrix.GetLongLength(0);
        bool colInRange = col < 0 || col >= matrix.GetLongLength(1);

        if (rowInRange || colInRange || matrix[row, col] == 0)
        {
            return;
        }

        if (matrix[row, col] == currentNumber)
        {
            matrix[row, col] = 0;
            currentLength++;

            InRange(row - 1, col); // recursive
            InRange(row + 1, col); // recursive
            InRange(row, col - 1); // recursive
            InRange(row, col + 1); // recursive
        }
    }

    private static void PrintMatrix(int[,] matrix) // print Matrix
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

        Console.WriteLine();
    }
}