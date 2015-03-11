using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// 
/// Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
/// Use generic method (read in Internet about generic methods in C#).
/// 
/// </summary>
class NumberCalculations
{
    static void Main()
    {
        // Input
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

        // Solution
        int min = MinimalNumber(array);
        int max = MaximalNumber(array);
        double aver = Average(array);
        int sum = Sum(array);
        int product = Product(array);

        // Output
        Console.WriteLine();
        Console.WriteLine("Minimal number is {0}", MinimalNumber<int>(min));
        Console.WriteLine();
        Console.WriteLine("Maximal number is {0}", MaximalNumber<int>(max));
        Console.WriteLine();
        Console.WriteLine("Average number is {0}", Average<double>(aver));
        Console.WriteLine();
        Console.WriteLine("Sum of number is {0}", Sum<int>(sum));
        Console.WriteLine();
        Console.WriteLine("Product number is {0}", Product<int>(product));

    }

    static T MinimalNumber<T>(params T[] values) where T : IComparable
    {
        T min = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (min.CompareTo(values[i]) > 0)
            {
                min = values[i];
            }
        }

        return min;
    }

    static T MaximalNumber<T>(params T[] values) where T : IComparable
    {
        T min = values[0];
        T max = values[0];
        dynamic sum = values[0];
        dynamic product = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            if (max.CompareTo(values[i]) < 0)
            {
                max = values[i];
            }
        }

        return max;
    }

    static T Sum<T>(params T[] values) where T : IComparable
    {
        dynamic sum = values[0];
        dynamic product = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            sum += values[i];
        }

        return sum;
    }

    static T Product<T>(params T[] values) where T : IComparable
    {
        dynamic sum = values[0];
        dynamic product = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            product *= values[i];
        }

        return product;
    }

    static T Average<T>(params T[] values) where T : IComparable
    {
        dynamic aver = values[0];

        for (int i = 1; i < values.Length; i++)
        {
            aver += values[i];
        }

        aver /= values.Length;
        return aver;
    }
}