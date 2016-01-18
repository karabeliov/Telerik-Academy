using System;
/// <summary>
/// 
/// Print some posters with the Telerik Logo in different sizes
/// 
/// </summary>
class TelerikLogoMatrix
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int size = (input * 3) - 2;
        int[,] matrix = new int[size, size];

        int currentRow = input / 2;
        int currentCol = 0;

        matrix[currentRow, currentCol] = 1;
        // diractions "up-right"
        for (int i = currentRow; i > 0; i--)
        {
            currentRow--;
            currentCol++;
            matrix[currentRow, currentCol] = 1;
        }
        // diractions "down-right"
        for (int i = 0; i < size - input; i++)
        {
            currentRow++;
            currentCol++;
            matrix[currentRow, currentCol] = 1;
        }
        // diractions "down-left"
        for (int i = size - input; i < size - 1; i++)
        {
            currentRow++;
            currentCol--;
            matrix[currentRow, currentCol] = 1;
        }
        // diractions "up-left"
        for (int i = size - 1; i > size - input; i--)
        {
            currentRow--;
            currentCol--;
            matrix[currentRow, currentCol] = 1;
        }
        // diractions "up-right"
        for (int i = size - input - 1; i >= 0; i--)
        {
            currentRow--;
            currentCol++;
            matrix[currentRow, currentCol] = 1;
        }
        // diractions "down-right"
        for (int i = 0; i < input / 2; i++)
        {
            currentRow++;
            currentCol++;
            matrix[currentRow, currentCol] = 1;
        }

        // Print Matrix
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
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