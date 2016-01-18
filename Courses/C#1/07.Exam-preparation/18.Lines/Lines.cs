using System;
/// <summary>
/// 
/// 
/// 
/// </summary>
class Lines
{
    static void Main()
    {
        int size = 8;
        int[,] matrix = new int[size, size];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = (number >> col) & 1;
            }
        }

        int longestLine = 0;
        int longestCount = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int currentLine = 0;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                while ( col < matrix.GetLength(1) && matrix[row, col] == 1)
                {
                    currentLine++;
                    col++;
                }

                if (currentLine > longestLine)
                {
                    longestLine = currentLine;
                    longestCount = 1;
                }
                else if (currentLine == longestLine)
                {
                    longestCount++;
                }

                currentLine = 0;
            }
        }

        for (int col = 0; col < matrix.GetLength(0); col++)
        {
            int currentLine = 0;
            for (int row = 0; row < matrix.GetLength(1); row++)
            {
                while (row < matrix.GetLength(1) && matrix[row, col] == 1)
                {
                    currentLine++;
                    row++;
                }

                if (currentLine > longestLine)
                {
                    longestLine = currentLine;
                    longestCount = 1;
                }
                else if (currentLine == longestLine)
                {
                    longestCount++;
                }

                currentLine = 0;
            }
        }

        if (longestLine == 1)
        {
            longestCount = longestCount / 2;
        }

        Console.WriteLine(longestLine);
        Console.WriteLine(longestCount);
    }
}