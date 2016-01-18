using System;
/// <summary>
/// 
/// https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/02.%20Multidimensional%20Arrays/README.md
/// Write a program that fills and prints a matrix of size (n, n) as shown below:
/// 
/// </summary>
class FillМatrix
{
    static void Main()
    {
        // Input
        Console.Write("Enter size of matrix: ");
        int size = int.Parse(Console.ReadLine());

        Console.Write("Enter example (a, b, c or d): ");
        string examp = Console.ReadLine();
        examp = examp.ToUpper(); // make upperCase

        int[,] matrixA = new int[size, size];  // examp A
        int[,] matrixB = new int[size, size];  // examp B
        int[,] matrixC = new int[size, size];  // examp C
        int[,] matrixD = new int[size, size];  // examp D
        string diractions = "down";
        int counter = 1;
        int currentRow = 0;
        int currentCol = 0;
        Console.WriteLine();

        // Solution
        if (examp == "A")
        {
            Console.WriteLine("Example A!");
            Console.WriteLine();

            for (int col = 0; col < matrixA.GetLength(1); col++)
            {
                for (int row = 0; row < matrixA.GetLength(0); row++)
                {
                    matrixA[row, col] = counter++;
                }
            }

            PrintMatrix(matrixA);
            return;
        }
        else if (examp == "B")
        {
            Console.WriteLine("Example B!");
            Console.WriteLine();

            for (int col = 0; col < matrixB.GetLength(1); col++)
            {
                for (int row = 0; row < matrixB.GetLength(0); row++)
                {
                    if (diractions == "down")
                    {
                        if (matrixB[0, size - 1] == size * size)
                        {
                            PrintMatrix(matrixB);
                            return;
                        }
                        for (int i = 0; i < size; i++)
                        {
                            matrixB[currentRow++, currentCol] = counter++;
                        }

                        diractions = "left";
                        currentRow--;
                    }
                    if (diractions == "left")
                    {
                        currentCol++;
                        for (int i = 0; i < size; i++)
                        {
                            matrixB[currentRow--, currentCol] = counter++;
                        }

                        currentRow++;
                        diractions = "down";
                        currentCol++;
                    }
                }
            }
        }
        else if (examp == "C")
        {
            Console.WriteLine("Example C!");
            Console.WriteLine();

            currentRow = size - 1;
            currentCol = 0;
            counter = 1;
            int start = size - 1;

            // full half matrix
            for (int i = start; i >= 0; i--)
            {
                matrixC[i, currentCol] = counter++;
                currentCol = 0;
                currentRow = i;
                for (int j = i; j < start; j++)
                {
                    currentRow++;
                    currentCol++;
                    matrixC[currentRow, currentCol] = counter++;
                }

                currentCol = 0;
            }

            // full other half 
            currentRow = 0;
            currentCol = size - 1;
            counter = size * size;
            start = 0;
            for (int i = start; i < size - 1; i++)
            {
                matrixC[i, currentCol] = counter--;
                currentCol = size - 1;
                currentRow = i;
                for (int j = 0; j < i; j++)
                {
                    currentRow--;
                    currentCol--;
                    matrixC[currentRow, currentCol] = counter--;
                }

                currentCol = size - 1;
            }

            PrintMatrix(matrixC);
        }
        if (examp == "D")
        {
            Console.WriteLine("Example D!");
            Console.WriteLine();

            diractions = "down";
            for (int row = 0; row < matrixD.GetLength(0); row++)
            {
                for (int col = 0; col < matrixD.GetLength(1); col++)
                {
                    if (diractions == "down")
                    {
                        for (int i = 0; i < size; i++)
                        {
                            if (matrixD[currentRow, currentCol] == 0)
                            {
                                matrixD[currentRow++, currentCol] = counter++;
                            }
                        }

                        diractions = "left";
                        currentRow--;
                    }
                    if (diractions == "left")
                    {
                        currentCol++;
                        for (int i = 0; i < size - 1; i++)
                        {
                            if (matrixD[currentRow, currentCol] == 0)
                            {
                                matrixD[currentRow, currentCol++] = counter++;
                            }
                        }

                        diractions = "up";
                        currentCol--;
                    }
                    if (diractions == "up")
                    {
                        currentRow--;
                        for (int i = 0; i < size - 1; i++)
                        {
                            if (matrixD[currentRow, currentCol] == 0)
                            {
                                matrixD[currentRow--, currentCol] = counter++;
                            }
                        }

                        diractions = "right";
                        currentRow++;
                    }
                    if (diractions == "right")
                    {
                        currentCol--;
                        for (int i = 0; i < size - 1; i++)
                        {
                            if (matrixD[currentRow, currentCol] == 0)
                            {
                                matrixD[currentRow, currentCol--] = counter++;
                            }
                        }

                        diractions = "down";
                        currentCol++;
                        currentRow++;
                    }
                }
            }

            PrintMatrix(matrixD);
            return;
        }
    }
    // Output
    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, -3} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
}