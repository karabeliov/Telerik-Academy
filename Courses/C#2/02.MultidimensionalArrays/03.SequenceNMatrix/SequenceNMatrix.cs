using System;
/// <summary>
/// 
/// https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/02.%20Multidimensional%20Arrays/README.md to take emaxple
/// We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
/// Write a program that finds the longest sequence of equal strings in the matrix.
/// 
/// </summary>
class SequenceNMatrix
{
    static void Main()
    {
        // Input
        Console.Write("Enter size of matrix rows(N): ");
        int rowSize = int.Parse(Console.ReadLine());

        Console.Write("Enter size of matrix cols(M): ");
        int colSize = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rowSize, colSize];
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("Matrix[{0}, {1}] = ", row, col);
                matrix[row, col] = Console.ReadLine();
            }
        }

        // Solution
        int currentSum = 0;
        string bestString = string.Empty;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int counter = 0;
                for (int platformRow = row; platformRow < matrix.GetLength(0); platformRow++)
                {
                    for (int platformCol = col; platformCol < matrix.GetLength(1); platformCol++)
                    {
                        if (matrix[row, col].Equals(matrix[platformRow, platformCol]))
                        {
                            counter++;
                        }

                        if (counter > currentSum)
                        {
                            currentSum = counter;
                            bestString = matrix[row, col];
                        }
                    }
                }
            }
        }

        // Output
        PrintMatrix(matrix);

        Console.WriteLine();

        for (int i = 0; i < currentSum; i++)
        {
            if (i == currentSum - 1)  // remove last coma
            {
                Console.Write("{0}", bestString);
            }
            else
            {
                Console.Write("{0}, ", bestString);
            }
        }

        Console.WriteLine();
    }

    private static void PrintMatrix(string[,] matrix)
    {
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(" {0,-5}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}