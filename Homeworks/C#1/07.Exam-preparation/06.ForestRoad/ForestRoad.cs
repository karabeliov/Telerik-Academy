using System;
/// <summary>
/// 
/// This is from exam http://bgcoder.com/Contests/1/CSharp-Fundamentals-2011-2012-Part-1-Sample-Exam
/// 
/// </summary>
class ForestRoad
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int width = N;
        int height = N * 2 - 1;
        int[,] matrix = new int[height, width];

        int currenRow = 0;
        int currenCol = 0;       
        for (int i = 0; i < height; i++)
        {
            if (i < height / 2)
            {
                // diractions "down-right"
                matrix[currenRow++, currenCol++] = 1;
            }
            else
            {
                // diractions "down-left"
                matrix[currenRow++, currenCol--] = 1;
            }
        }
        // Print Matrix
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
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