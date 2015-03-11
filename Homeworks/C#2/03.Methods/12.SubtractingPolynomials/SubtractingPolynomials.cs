using System;
/// <summary>
/// 
/// Extend the previous program to support also subtraction and multiplication of polynomials.
/// 
/// </summary>
class SubtractingPolynomials
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
        int[] subtraction = SubtractionPolynomials(fPolynomial, sPolynomial);
        int[] multiplication = MultiplicationPolynomials(fPolynomial, sPolynomial);

        // Output
        Console.Clear();

        // Sum Polynomials
        Console.WriteLine();
        PrintPolynomial(fPolynomial, '+');
        Console.WriteLine("+");
        PrintPolynomial(sPolynomial, '+');
        Console.WriteLine("=");
        PrintPolynomial(sum, '+');
        Console.WriteLine(new string('-', 30));

        // Subtraction Polynomials
        Console.WriteLine();
        PrintPolynomial(fPolynomial, '-');
        Console.WriteLine("-");
        PrintPolynomial(sPolynomial, '-');
        Console.WriteLine("=");
        PrintPolynomial(subtraction, '-');
        Console.WriteLine(new string('-', 30));

        // Multiplication Polynomials
        Console.WriteLine();
        PrintPolynomial(fPolynomial, '*');
        Console.WriteLine("*");
        PrintPolynomial(sPolynomial, '*');
        Console.WriteLine("=");
        PrintPolynomial(multiplication, '*');
    }

    private static void PrintPolynomial(int[] fPolynomial, char sign)
    {
        int count = fPolynomial.Length - 1;
        for (int i = 0; i < fPolynomial.Length; i++)
        {
            if (i != fPolynomial.Length - 1)
            {
                Console.Write("{0}x^{1} {2} ", fPolynomial[i], count--, sign);
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

    private static int[] SubtractionPolynomials(int[] fPolynomial, int[] sPolynomial)
    {
        int size = sPolynomial.Length;
        int[] subtraction = new int[size];

        for (int i = 0; i < size; i++)
        {
            subtraction[i] = fPolynomial[i] - sPolynomial[i];
        }

        return subtraction;
    }

    private static int[] MultiplicationPolynomials(int[] fPolynomial, int[] sPolynomial)
    {
        int size = sPolynomial.Length;
        int[] multiplication = new int[size];

        for (int i = 0; i < size; i++)
        {
            multiplication[i] = fPolynomial[i] * sPolynomial[i];
        }

        return multiplication;
    }
}