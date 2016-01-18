using System;
using System.Text;
class FallDownMatrix
{
    static void Main()
    {
        byte size = 8;
        int[,] matrix = new int[size, size];

        // Input
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int number = int.Parse(Console.ReadLine());
            string bits = Convert.ToString(number, 2).PadLeft(8, '0');          
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(bits[col].ToString());
            }
        }

        // Solution
        for (int col = 0; col < matrix.GetLength(1); col++) // after that change colomn
        {
            int count = 0; // clean every time 0
            for (int row = 0; row < matrix.GetLength(0); row++) // first search in row (fast loop)
            {
                if (matrix[row, col] == 1)
                {
                    count++;
                    matrix[row, col] = 0;
                }
            }

            for (int i = 0; i < count; i++) // full the matrix with count time "1" from bottom
            {
                matrix[7 - i, col] = 1;
            }
        }
        

        // Print Matrix only to see the result

        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write(matrix[row, col] + " ");
        //    }
        //    Console.WriteLine();
        //}


        // Output
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            StringBuilder sb = new StringBuilder();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sb.Append(matrix[row, col]); // add all 1
            }

            int num = Convert.ToInt32(sb.ToString(), 2); // convert to int from bits(string)

            Console.WriteLine(num); // print numbers
        }
    }
}