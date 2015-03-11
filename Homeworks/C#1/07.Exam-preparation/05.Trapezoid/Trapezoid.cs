using System;
/// <summary>
/// 
/// This is from exam http://bgcoder.com/Contests/3/CSharp-Fundamentals-2011-2012-Part-1-Test-Exam
/// 
/// </summary>
class Trapezoid
{
    static void Main()
    {
        Console.Write("Enter size of Trapezoid: ");
        int N = int.Parse(Console.ReadLine());
        int width = N;
        int bottomWidth = 2 * N;
        int height = N;
        int[,] matrix = new int[height, bottomWidth];

        // diractions "right"
        int currentRow = 0;
        int currentCol = N;
        for (int i = 0; i < N; i++)
        {
            matrix[currentRow, currentCol++] = 1;
        }
        // diractions "down"
        currentRow = 0;
        currentCol = matrix.GetLength(1) - 1;
        for (int i = 0; i < height; i++)
        {
            matrix[currentRow++, currentCol] = 1;
        }
        // diractions "left"
        currentRow = matrix.GetLength(0) - 1;
        currentCol = matrix.GetLength(1) - 1;
        for (int i = 0; i < bottomWidth; i++)
        {
            matrix[currentRow, currentCol--] = 1;
        }
        // diractions "up"
        currentRow = matrix.GetLength(0) - 1;
        currentCol = 0;
        for (int i = 0; i < height; i++)
        {
            matrix[currentRow--, currentCol++] = 1;
        }

        // Print Matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}