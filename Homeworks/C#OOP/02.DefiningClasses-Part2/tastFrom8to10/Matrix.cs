namespace tastFrom8to10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Matrix<T> where T : struct // only struct members 
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;

            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get { return rows; }
            set 
            {
                if (rows < 0)
                {
                    throw new IndexOutOfRangeException("Rows can be smaller the zero");
                }

                rows = value; 
            }
        }

        public int Cols
        {
            get { return cols; }
            set 
            {
                if (cols < 0)
                {
                    throw new IndexOutOfRangeException("Cols can be smaller the zero");
                }

                cols = value; 
            }
        }
        
        public T this[int rows, int cols] // indexer
        {
            get 
            { 
                return matrix[rows, cols]; 
            }
            set
            {
                matrix[rows, cols] = value;
            }
        }

        public static Matrix<T> operator + (Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new InvalidOperationException("Matrices must be with equel size");
            }

            Matrix<T> adding = new Matrix<T>(first.Rows, first.Cols);

            for (int row = 0; row < adding.Rows; row++)
            {
                for (int col = 0; col < adding.Cols; col++)
                {
                    adding[row, col] = (dynamic)first[row, col] + second[row, col];
                }
            }

            return adding;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new InvalidOperationException("Matrices must be with equel size");
            }

            Matrix<T> subtracting = new Matrix<T>(first.Rows, first.Cols);

            for (int row = 0; row < subtracting.Rows; row++)
            {
                for (int col = 0; col < subtracting.Cols; col++)
                {
                    subtracting[row, col] = (dynamic)first[row, col] - second[row, col];
                }
            }

            return subtracting;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new InvalidOperationException("Matrices must be with equel size");
            }

            Matrix<T> multiplying = new Matrix<T>(first.Rows, first.Cols);

            for (int row = 0; row < multiplying.Rows; row++)
            {
                for (int col = 0; col < multiplying.Cols; col++)
                {
                    multiplying[row, col] = (dynamic)first[row, col] * second[row, col];
                }
            }

            return multiplying;
        }

        private static bool OverrideBool(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col] != (dynamic)0)
                        return true;
                }
            }
            return false;
        }
        public static bool operator true(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }

        public static bool operator false(Matrix<T> matrix)
        {
            return OverrideBool(matrix);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    result.Append(string.Format("{0,3}", matrix[row, col]));
                }

                result.AppendLine();
            }

            return result.ToString().TrimEnd();
        }
    }
}
