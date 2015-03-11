using System;
/// <summary>
/// 
/// Write a class Matrix, to hold a matrix of integers. 
/// Overload the operators for adding, subtracting and multiplying of matrices, indexer for accessing the matrix content and ToString().
/// 
/// </summary>
class MatrixClass
{
    static void Main()
    {
        Matrix matrix1 = new Matrix(2, 2);
        matrix1[0, 0] = 5;
        matrix1[1, 1] = 10;

        Matrix matrix2 = new Matrix(2, 2);
        matrix2[0, 0] = 4;
        matrix2[1, 1] = 10;

        Matrix subtracting = matrix1 - matrix2;
        Matrix adding = matrix1 + matrix2;
        Matrix multiplying = matrix1 * matrix2;

        Console.WriteLine("Subtracting: \n" + subtracting);
        Console.WriteLine("Adding: \n" + adding);
        Console.WriteLine("Multiplying: \n" + multiplying);
    }
}