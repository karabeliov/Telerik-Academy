using System;

public class Cube
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        int size = input * 2 - 1;
        int[,] matrix = new int[size, size];

        int currentRow = 0;
        int currentCol = input - 1;
        matrix[currentRow, currentCol] = 1;

        // Draw Contur Cube
        {
            // diractions "right"
            for (int i = currentCol; i < matrix.GetLength(1) - 1; i++)
            {
                currentCol++;
                matrix[currentRow, currentCol] = 1;
            }

            // diractions "down"
            for (int i = 0; i < input - 1; i++)
            {
                currentRow++;
                matrix[currentRow, currentCol] = 1;
            }

            // diractions "down-left"
            for (int i = 0; i < input - 1; i++)
            {
                currentRow++;
                currentCol--;
                matrix[currentRow, currentCol] = 1;
            }

            currentRow = 0;
            currentCol = input - 1;

            // diractions "down-left"
            for (int i = 0; i < input - 1; i++)
            {
                currentRow++;
                currentCol--;
                matrix[currentRow, currentCol] = 1;
            }

            for (int i = 0; i < input - 1; i++)
            {
                currentCol++;
                matrix[currentRow, currentCol] = 1;
            }

            // diractions "down-right"
            for (int i = 0; i < input - 1; i++)
            {
                currentRow++;
                matrix[currentRow, currentCol] = 1;
            }

            currentRow = input - 1;
            currentCol = 0;

            // diractions "down-right"
            for (int i = 0; i < input - 1; i++)
            {
                currentRow++;
                matrix[currentRow, currentCol] = 1;
            }

            // diractions "right"
            for (int i = currentCol; i < input - 1; i++)
            {
                currentCol++;
                matrix[currentRow, currentCol] = 1;
            }

            currentRow = 0;
            currentCol = size - 1;

            // diractions "down-left"
            for (int i = 0; i < input - 1; i++)
            {
                currentRow++;
                currentCol--;
                matrix[currentRow, currentCol] = 1;
            }           
        }

        // Full cube top
        currentRow = 1;
        currentCol = input - 1;
        int count = input - 2;
        int counter = 1;

        while (count != 0)
        {
            for (int k = input - 1; k < size - 2; k++)
            {
                matrix[currentRow, currentCol++] = 2;
            }

            currentRow++;
            counter++;
            currentCol = input - counter;
           
            count--;
        }

        // Full right Half
        currentRow = 2;
        currentCol = size - 2;
        count = input - 2;
        counter = 1;

        while (count != 0)
        {
            for (int k = 0; k < counter; k++)
            {
                matrix[currentRow, currentCol++] = 3;
            }

            currentRow++;
            counter++;
            currentCol = size - 1 - counter;   
     
            count--;
        }

        // Other Half
        currentRow = input;
        currentCol = input;
        count = input - 2;
        int countPrint = input - 3;

        while (count != 0)
        {
            for (int i = 0; i < countPrint; i++)
            {
                matrix[currentRow, currentCol++] = 3;
            }

            currentRow++;
            currentCol = input;
            countPrint--;

            count--;
        }

        // Print Matrix
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write(" ");
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write(":");
                }
                else if (matrix[row, col] == 2)
                {
                    Console.Write("/");
                }
                else if (matrix[row, col] == 3)
                {
                    Console.Write("X");
                }
            }

            Console.WriteLine();
        }
    }
}