using System;

class Spiral
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] spiral = new int[size, size];

        string diraction = "right";
        int currentRow = 0;
        int currentCol = 0;

        for (int i = 1; i <= size * size; i++)
        {
            if (diraction == "right" && (currentCol >= size || spiral[currentRow, currentCol] != 0))
            {
                currentCol--;
                currentRow++;
                diraction = "down";
            }
            else if (diraction == "down" && (currentRow >= size || spiral[currentRow, currentCol] != 0))
            {
                currentRow--;
                currentCol--;
                diraction = "left";
            }
            else if (diraction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
            {
                currentCol++;
                currentRow--;
                diraction = "up";
            }
            else if (diraction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
            {
                currentRow++;
                currentCol++;
                diraction = "right";
            }

            spiral[currentRow, currentCol] = i;

            switch (diraction)
            {
                case "right":
                    currentCol++;                   
                    break;
                case "down":
                    currentRow++;                    
                    break;
                case "left":
                    currentCol--;                    
                    break;
                case "up":
                    currentRow--;                   
                    break;
            }
        }

        // Print Matrix
        for (int row = 0; row < spiral.GetLength(0); row++)
        {
            for (int col = 0; col < spiral.GetLength(1); col++)
            {
                Console.Write(spiral[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}