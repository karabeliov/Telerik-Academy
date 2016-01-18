using System;
/// <summary>
/// 
/// Print on the console a torch of fire with width N.
/// 
/// </summary>
class FireMatrix
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N / 2, N];
        int[,] cup = new int[N / 2, N];

        int currentRow = 0;
        int currentCol = N / 2;

        for (int i = 0; i < N / 2; i++)
        {
            matrix[currentRow++, currentCol++] = 1;          
        }        
        currentRow = 0;
        currentCol = N / 2 - 1;
        for (int i = 0; i < N / 2; i++)
        {
            matrix[currentRow++, currentCol--] = 1;
        }
        // Print Matrix
        for (int row = 0; row < N / 2; row++)
        {
            for (int col = 0; col < N; col++)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write(".");
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write("#");
                }               
            }
            Console.WriteLine();
        }
        // Print Revert Matrix
        for (int row = N / 2 - 1; row >= N / 4; row--)
        {
            for (int col = N - 1; col >= 0; col--)
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write(".");
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write("#");
                }
            }
            Console.WriteLine();
        }
        // Line 
        Console.WriteLine(new string('-', N));   
        // Print Cup
        int dotsCup = 0;
        int halfInput = N / 2;
        for (int i = 0; i < N / 2; i++)
        {
            Console.Write(new string('.', dotsCup));
            Console.Write(new string('\\', halfInput));
            Console.Write(new string('/', halfInput));
            Console.Write(new string('.', dotsCup));
            halfInput--;
            dotsCup++;
            Console.WriteLine();
        }
    }
}