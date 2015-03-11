using System;
/// <summary>
/// 
/// 
/// 
/// </summary>
class Pillars
{
    static void Main()
    {
        int[,] matrix = new int[8, 8];

        for (int row = 0; row < 8; row++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int col = 0; col < 8; col++)
            {
                matrix[row, col] = (number >> col) & 1;
            }
        }

        int pillarsIndex = 7;
        int countBitsLeft = 0;
        int countBitsRight = 0;
        bool foundSolution = false;
        while (pillarsIndex >= 0)
        {
            countBitsLeft = 0;
            countBitsRight = 0;
            for (int col = 0; col < pillarsIndex; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        countBitsLeft++;
                    }
                }
            }

            for (int col = pillarsIndex + 1; col < pillarsIndex; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        countBitsRight++;
                    }
                }
            }

            if (countBitsLeft == countBitsRight)
            {
                foundSolution = true;
                break;
            }

            pillarsIndex--;
        }

        if (foundSolution)
        {
            Console.WriteLine(pillarsIndex);
            Console.WriteLine(countBitsLeft);
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}