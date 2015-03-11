using System;
/// <summary>
/// 
/// This is from exam http://bgcoder.com/Contests/41/Telerik-Academy-Exam-1-27-Dec-2012
/// 
/// </summary>
class Carpets
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];

        int startSlash = size / 2 - 1;
        int endSlash = size / 2 - 1;

        bool isSlash = true;
        for (int row = 0; row < matrix.GetLength(0) / 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) / 2; col++)
            {
                if (startSlash <= col && col <= endSlash)
                {
                    if (isSlash)
                    {
                        matrix[row, col] = 2; // print slash
                        matrix[row, size - 1 - col] = 3; // simetric print backSlach col
                        matrix[size - 1 - row, col] = 3; // simetric print backSlash row
                        matrix[size - 1 - row, size - 1 - col] = 2; // simetric print Slash row / col
                        isSlash = false;
                    }
                    else
                    {
                        matrix[row, col] = 1; // print space
                        matrix[row, size - 1 - col] = 1; // simetric print space col
                        matrix[size - 1 - row, col] = 1; // simetric print space row
                        matrix[size - 1 - row, size - 1 - col] = 1; // simetric print space row / col
                        isSlash = true;
                    }
                    
                }
            }

            isSlash = true;
            startSlash--;
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
                else if (matrix[row, col] == 1)
                {
                    Console.Write(" ");
                }
                else if (matrix[row, col] == 2)
                {
                    Console.Write("/");
                }
                else if (matrix[row, col] == 3)
                {
                    Console.Write("\\");
                }
            }

            Console.WriteLine();
        }
    }
}