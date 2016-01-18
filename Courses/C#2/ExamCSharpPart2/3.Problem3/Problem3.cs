using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
class Problem3
{
    static int rows;
    static int cols;
    static List<string> moves;
    static List<int> movesNum;
    static int nMove;
    static void Main()
    {
        int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); // read input and make array   this is slow!!!
        rows = size[0];
        cols = size[1];
        int[,] matrix = new int[rows, cols];
        matrix = FullMatrix(matrix);

        ReadMoves();  // !!!

        long sumValue = GetValueInCell(matrix, moves, movesNum);

        Console.WriteLine(sumValue);
    }

    private static long GetValueInCell(int[,] matrix, List<string> moves, List<int> movesNum)
    {
        int sizeRow = matrix.GetLength(0);
        int sizeCol = matrix.GetLength(1);
        string diractions = moves[0];

        int currentRow = rows - 1;
        int currentCol = 0;
        long sumValue = 0;

        for (int n = 0; n < nMove; n++)
        {
            switch (moves[n])
            {
                case "RU":

                    for (int i = 0; i < movesNum[n]; i++)
                    {
                        if (currentRow < sizeRow && currentCol < sizeCol && currentRow >= 0 && currentCol >= 0)
                        {
                            sumValue += matrix[currentRow--, currentCol++];
                            matrix[++currentRow, --currentCol] = 0;
                            if (i != movesNum[n] - 1)
                            {
                                currentRow--;
                                currentCol++;
                            }
                        }
                        if (currentRow < 0)
                        {
                            currentRow = 0;
                        }
                        if (currentCol > sizeCol - 1)
                        {
                            currentCol = sizeCol - 1;
                        }
                    }
                    break;
                case "UR":

                    for (int i = 0; i < movesNum[n]; i++)
                    {
                        if (currentRow < sizeRow && currentCol < sizeCol && currentRow >= 0 && currentCol >= 0)
                        {
                            sumValue += matrix[currentRow--, currentCol++];
                            matrix[++currentRow, --currentCol] = 0;

                            if (i != movesNum[n] - 1)
                            {
                                currentRow--;
                                currentCol++;
                            }
                        }

                        if (currentRow < 0)
                        {
                            currentRow = 0;
                        }
                        if (currentCol > sizeCol - 1)
                        {
                            currentCol = sizeCol - 1;
                        }
                    }
                    break;
                case "LU":
                    for (int i = 0; i < movesNum[n]; i++)
                    {
                        if (currentRow < sizeRow && currentCol < sizeCol && currentRow >= 0 && currentCol >= 0)
                        {
                            sumValue += matrix[currentRow--, currentCol--];
                            matrix[++currentRow, ++currentCol] = 0;
                            if (currentCol > 0)
                            {
                                currentRow--;
                                currentCol--;
                            }
                        }
                        if (currentRow < 0)
                        {
                            currentRow = 0;
                        }
                        if (currentCol < 0)
                        {
                            currentCol = 0;
                        }
                    }
                    break;
                case "UL":
                    for (int i = 0; i < movesNum[n]; i++)
                    {
                        if (currentRow < sizeRow && currentCol < sizeCol && currentRow >= 0 && currentCol >= 0)
                        {
                            sumValue += matrix[currentRow--, currentCol--];
                            matrix[++currentRow, ++currentCol] = 0;
                            if (i != movesNum[n] - 1)
                            {
                                currentRow--;
                                currentCol--;
                            }
                        }
                        if (currentRow < 0)
                        {
                            currentRow = 0;
                        }

                        if (currentCol < 0)
                        {
                            currentCol = 0;
                        }
                    }
                    break;
                case "DL":
                    for (int i = 0; i < movesNum[n]; i++)
                    {
                        if (currentRow < sizeRow && currentCol < sizeCol && currentRow >= 0 && currentCol >= 0)
                        {
                            sumValue += matrix[currentRow++, currentCol--];
                            matrix[--currentRow, ++currentCol] = 0;
                            if (i != movesNum[n] - 1)
                            {
                                currentRow++;
                                currentCol--;
                            }
                        }
                        if (currentRow > sizeRow - 1)
                        {
                            currentRow = sizeRow - 1;
                        }
                        if (currentCol < 0)
                        {
                            currentCol = 0;
                        }
                    }
                    break;
                case "LD":
                    for (int i = 0; i < movesNum[n]; i++)
                    {
                        if (currentRow < sizeRow && currentCol < sizeCol && currentRow >= 0 && currentCol >= 0)
                        {
                            sumValue += matrix[currentRow++, currentCol--];
                            matrix[--currentRow, ++currentCol] = 0;
                            if (i != movesNum[n] - 1)
                            {
                                currentRow++;
                                currentCol--;
                            }
                        }
                        if (currentRow > sizeRow - 1)
                        {
                            currentRow = sizeRow - 1;
                        }
                        if (currentCol < 0)
                        {
                            currentCol = 0;
                        }
                    }
                    break;
                case "RD":
                    for (int i = 0; i < movesNum[n]; i++)
                    {
                        if (currentRow < sizeRow && currentCol < sizeCol && currentRow >= 0 && currentCol >= 0)
                        {
                            sumValue += matrix[currentRow++, currentCol++];
                            matrix[--currentRow, --currentCol] = 0;
                            if (i != movesNum[n] - 1)
                            {
                                currentRow++;
                                currentCol++;
                            }
                        }
                        if (currentCol > sizeCol - 1)
                        {
                            currentCol = sizeCol - 1;
                        }
                        if (currentRow > sizeRow - 1)
                        {
                            currentRow = sizeRow - 1;
                        }
                    }
                    break;
                case "DR":
                    for (int i = 0; i < movesNum[n]; i++)
                    {
                        if (currentRow < sizeRow && currentCol < sizeCol && currentRow >= 0 && currentCol >= 0)
                        {
                            sumValue += matrix[currentRow++, currentCol++];
                            matrix[--currentRow, --currentCol] = 0;
                            if (i != movesNum[n] - 1)
                            {
                                currentRow++;
                                currentCol++;
                            }
                        }
                        if (currentCol > sizeCol - 1)
                        {
                            currentCol = sizeCol - 1;
                        }
                        if (currentRow > sizeRow - 1)
                        {
                            currentRow = sizeRow - 1;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        return sumValue;
    }

    private static void ReadMoves()
    {
        nMove = int.Parse(Console.ReadLine());
        moves = new List<string>();
        movesNum = new List<int>();
        for (int i = 0; i < nMove; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            moves.Add(input[0]);
            movesNum.Add(int.Parse(input[1]));
        }
    }

    private static int[,] FullMatrix(int[,] matrix)
    {
        int startRow = rows - 1;
        int startCol = 0;
        int startCounter = 0;
        for (int row = 0; row < matrix.GetLength(0); row++) // full first col
        {
            matrix[startRow--, startCol] = startCounter;
            startCounter += 3;
        }

        startRow = rows - 1;
        startCol = 0;
        startCounter = 0;
        for (int col = 0; col < matrix.GetLength(1); col++) // full last row
        {
            matrix[startRow, startCol++] = startCounter;
            startCounter += 3;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            startRow = i;
            startCol = 0;
            startCounter = matrix[startRow, startCol];
            for (int col = 0; col < matrix.GetLength(1); col++) // full last row
            {
                matrix[startRow, startCol++] = startCounter;
                startCounter += 3;
            }
        }

        return matrix;
    }
}