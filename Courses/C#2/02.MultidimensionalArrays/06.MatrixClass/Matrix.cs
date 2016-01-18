using System;

class Matrix
{
    private int[,] matrix;

    public Matrix(int row, int col)  // constructor like Method but he don't have name
    {
        this.matrix = new int[row, col];
    }
    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    } // property

    public int Cols
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    } // property

    public static Matrix operator +(Matrix first, Matrix second) // adding
    {
        Matrix adding = new Matrix(first.Rows, first.Cols);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                adding[row, col] = first[row, col] + second[row, col];
            }
        }

        return adding;
    }

    public static Matrix operator -(Matrix first, Matrix second) // subtracting
    {
        Matrix subtracting = new Matrix(first.Rows, first.Cols);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                subtracting[row, col] = first[row, col] - second[row, col];
            }
        }

        return subtracting;
    }

    public static Matrix operator *(Matrix first, Matrix second) // multiplying
    {
        Matrix multiplying = new Matrix(first.Rows, first.Cols);
        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                multiplying[row, col] = first[row, col] * second[row, col];
            }
        }

        return multiplying;
    }

    public int this[int row, int col] // indexer
    {
        get
        {
            return this.matrix[row, col];
        }

        set
        {
            this.matrix[row, col] = value;
        }
    }

    public override string ToString() // ToString() for print Matrix
    {
        string result = null;
        for (int row = 0; row < this.Rows; row++)  
        {
            for (int col = 0; col < this.Cols; col++) 
            {
                result += matrix[row, col] + " ";
            }

            result += Environment.NewLine;
        }

        return result;
    }
}