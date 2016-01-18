using System;

class KaspichaniaBoats
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int width = size * 2 + 1;
        int height = 6 + ((size - 3) / 2) * 3;
        int[,] matrix = new int[height, width];

        int currentRow = 0;
        int currentCol = size;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            matrix[currentRow++, currentCol] = 1;
        }

        currentRow = 0;
        currentCol = size;
        for (int row = 0; row <= size; row++)
        {
            matrix[currentRow++, currentCol++] = 1;
        }
        currentRow = 0;
        currentCol = size;
        for (int row = size; row >= 0 ; row--)
        {
            matrix[currentRow++, currentCol--] = 1;
        }
        currentRow = size;
        currentCol = 0;


        for (int row = 0; row < size / 2 + 2; row++)
        {
            matrix[currentRow++, currentCol++] = 1;
        }
        currentCol--;
        currentRow--;

        for (int row = 0; row < size ; row++)
        {
            matrix[currentRow, currentCol++] = 1;
        }

        currentRow = size;
        currentCol = width - 1;
        for (int row = 0; row < size / 2 + 2; row++)
        {
            matrix[currentRow++, currentCol--] = 1;
        }


        currentRow = size;
        currentCol = 0;
        for (int row = 0; row < width; row++)
        {
            matrix[currentRow, currentCol++] = 1;
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
                    Console.Write("*");
                }
            }
            Console.WriteLine();
        }
    }
}
