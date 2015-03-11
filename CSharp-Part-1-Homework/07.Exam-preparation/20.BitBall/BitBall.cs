using System;
/// <summary>
/// 
/// 
/// 
/// </summary>
class BitBall
{
    static void Main()
    {
        int size = 8;
        int[,] matrix = new int[size, size];

        for (int row = 0; row < size; row++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int col = 0; col < size; col++)
            {
                int bit = (number >> col) & 1;
                if (bit == 1)
                {
                    matrix[row, col] = 1;
                }
               
            }
        }

        for (int row = 0; row < size; row++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int col = 0; col < size; col++)
            {
                int bit = (number >> col) & 1;
                if (bit == 1)
                {
                    if (matrix[row, col] == 1)
                    {
                        matrix[row, col] = 0;
                    }
                    else
                    {
                        matrix[row, col] = 2;
                    }
                }

            }
        }

        int counter1 = 0;
        int counter2 = 0;
        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                if (matrix[row, col] == 1)
                {
                    break;
                }
                else if (matrix[row, col] == 2)
                {
                    counter2++;
                    break;
                }
            }
        }

        for (int col = 0; col < size; col++)
        {
            for (int row = size - 1; row >= 0; row--)
            {
                if (matrix[row, col] == 1)
                {
                    counter1++;
                    break;
                }
                else if (matrix[row, col] == 2)
                {
                    break;
                }
            }
        }

        Console.WriteLine("{0}:{1}", counter1, counter2);
    }
}