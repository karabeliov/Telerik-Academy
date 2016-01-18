namespace tastFrom8to10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class tastFrom8to10 
    {
        static void Main()
        {
            Matrix<int> firstMatrix = new Matrix<int>(5, 5);
            Matrix<int> secondMatrix = new Matrix<int>(5, 5);

            firstMatrix[0, 0] = 3;
            secondMatrix[0, 0] = 2;

            Matrix<int> sum = firstMatrix + secondMatrix;
            Matrix<int> subtracting = firstMatrix - secondMatrix;
            Matrix<int> multiplying = firstMatrix * secondMatrix;

            int firstElement = sum[0, 0];
            
            Console.WriteLine(sum);


            if (sum)
            {
                Console.WriteLine("Contains zero element(s)");
            }
            else
            {
                Console.WriteLine("Does not contain zero elements");
            }
        }
    }
}
