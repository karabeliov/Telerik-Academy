using System;
/// <summary>
/// 
/// You are given n integers (given in a single line, separated by a space).
/// Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
/// Elements are counted from 1 to n, so the first element is odd, the second is even, etc
/// 
/// </summary>
class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter numbers: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int productOdd = 1;
        int productEven = 1;

        for (int i = 0; i < numbers.Length; i++)
        {

            if (i % 2 == 0)
            {
                productEven *= int.Parse(numbers[i]);
            }
            else
            {
                productOdd *= int.Parse(numbers[i]);
            }
        }

        if (Equals(productOdd,productEven))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}