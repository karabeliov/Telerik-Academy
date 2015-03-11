using System;
/// <summary>
/// 
/// Write a method that adds two polynomials.
/// Represent them as arrays of their coefficients.
/// 
/// </summary>
class AddingPolynomials
{
    static void Main()
    {
        // Input
        // size of polynomials
        Console.Write("Enter size of polynomials: ");
        int polynomialsSize = int.Parse(Console.ReadLine());

        // first polynomials
        int[] fPolynomial = new int[polynomialsSize + 1]; 
        for (int i = 0; i <= polynomialsSize; i++)
        {
            Console.Write("Enter number in index[{0}] of first polynomial: ", i);
            fPolynomial[i] = int.Parse(Console.ReadLine());

        }

        Console.WriteLine();
        // second polynomials
        int[] sPolynomial = new int[polynomialsSize + 1];
        for (int i = 0; i <= polynomialsSize; i++)
        {
            Console.Write("Enter number in index[{0}] of second polynomial: ", i);
            sPolynomial[i] = int.Parse(Console.ReadLine());

        }

        // Solution
        // Adding polynomials
        int[] sum = SumPolynomials(fPolynomial, sPolynomial);

        // Output
        Console.WriteLine();
        PrintPolynomial(fPolynomial);
        Console.WriteLine("+");
        PrintPolynomial(sPolynomial);
        Console.WriteLine("=");
        PrintPolynomial(sum);
    }

    private static void PrintPolynomial(int[] fPolynomial)
    {
        int count = fPolynomial.Length - 1;
        for (int i = 0; i < fPolynomial.Length; i++)
        {
            if (i != fPolynomial.Length - 1)
            {
                Console.Write("{0}x^{1} + ", fPolynomial[i], count--);
            }
            else
            {
                Console.Write("{0}", fPolynomial[i]);
            }
        }
        Console.WriteLine();
    }

    private static int[] SumPolynomials(int[] fPolynomial, int[] sPolynomial)
    {
        int size = sPolynomial.Length;
        int[] sum = new int[size];

        for (int i = 0; i < size; i++)
        {
            sum[i] = fPolynomial[i] + sPolynomial[i];
        }

        return sum;
    }
}