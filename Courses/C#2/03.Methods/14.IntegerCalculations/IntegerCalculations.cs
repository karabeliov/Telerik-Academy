using System;
using System.Linq;
/// <summary>
/// 
/// Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
/// Use variable number of arguments.
/// 
/// </summary>
class IntegerCalculations
{
    static void Main()
    {
        Console.Write("Enter size of array: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine();
        Console.WriteLine("Enter {0} numbers!", size);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter number on index[{0}]: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int min = MinimalNumber(array);
        int max = MaximalNumber(array);
        double aver = Average(array);
        int sum = Sum(array);
        int product = Product(array);

        Console.WriteLine();
        Console.WriteLine("Minimal number is {0}", min);
        Console.WriteLine();
        Console.WriteLine("Maximal number is {0}", max);
        Console.WriteLine();
        Console.WriteLine("Average number is {0}", aver);
        Console.WriteLine();
        Console.WriteLine("Sum of number is {0}", sum);
        Console.WriteLine();
        Console.WriteLine("Product number is {0}", product);
        
    }

    private static int Product(int[] array)
    {
        int product = 1;

        for (int index = 0; index < array.Length; index++)
        {
            product *= array[index];
        }

        return product;
    }

    private static int Sum(int[] array)
    {
        int sum = array.Sum();
        return sum;
    }

    private static double Average(int[] array)
    {
        double aver = array.Average();
        return aver;
    }

    private static int MaximalNumber(int[] array)
    {
        int max = array.Max();
        return max;
    }

    private static int MinimalNumber(int[] array)
    {
        int min = array.Min();
        return min;
    }
}