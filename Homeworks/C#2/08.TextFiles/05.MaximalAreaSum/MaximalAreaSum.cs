using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/// <summary>
/// 
/// Write a program that reads a text file containing a square matrix of numbers.
/// Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
///  - The first line in the input file contains the size of matrix N.
///  - Each of the next N lines contain N numbers separated by space.
///  - The output should be a single number in a separate text file.
/// 
/// </summary>
class MaximalAreaSum
{
    static void Main()
    {
        int size = 0;
        int[,] matrix;
        
        try
        {
            // Input
            string path = @"..\..\fileFolder\text.txt";
            var reader = new StreamReader(path, Encoding.GetEncoding("UTF-8"));
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            using (reader)
            {
                size = int.Parse(reader.ReadLine());
                matrix = new int[size, size];

                for (int row = 0; row < size; row++)
                {
                    string[] numbers = reader.ReadLine().Split(' ');

                    for (int col = 0; col < size; col++)
                    {
                        matrix[row, col] = int.Parse(numbers[col]);
                    }
                }
            }

            // Solution
            int bestSum = int.MinValue;

            // Platform
            int height = 2;
            int width = 2;

            int bestRow = 0;
            int bestCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - height + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - width + 1; col++)
                {
                    int currentSum = 0;
                    for (int platformRow = row; platformRow < row + height; platformRow++)
                    {
                        for (int platformCol = col; platformCol < col + width; platformCol++)
                        {
                            currentSum += matrix[platformRow, platformCol];
                        }
                    }

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            // Output
            var write = new StreamWriter(@"..\..\fileFolder\output.txt",false, Encoding.GetEncoding("UTF-8"));

            using (write)
            {
                write.Write(bestSum);
                Console.WriteLine("The result is transer in to a separate text file!");
            }
            Console.WriteLine("Maximal sum in platform [{0} x {1}] is {2}", height, width, bestSum);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Can not find file!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Invalid directory in the file path!");
        }
        catch (IOException)
        {
            Console.WriteLine("Can not open the file!");
        }
        catch (Exception)
        {
            Console.WriteLine("Fatal Error!!!");
        }
    }
}