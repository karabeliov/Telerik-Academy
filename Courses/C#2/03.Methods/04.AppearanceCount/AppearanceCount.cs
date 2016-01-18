using System;
/// <summary>
/// 
/// Write a method that counts how many times given number appears in given array.
/// Write a test program to check if the method is workings correctly.
/// 
/// </summary>
class AppearanceCount
{
    static void Main()
    {
        // Input
        Console.Write("Enter Length of Array: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[] numbers = new int[length];

        for (int index = 0; index < numbers.Length; index++)
        {
            Console.Write("Enter number in the index[{0}]: ", index);
            numbers[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter number to check: ");
        int checkNumber = int.Parse(Console.ReadLine());

        // Solution
        int count = Counter(numbers, checkNumber);

        // Output
        Console.WriteLine();
        if (count == 0)
        {
            Console.WriteLine("This number ({0}) is not appearance!", checkNumber);
        }
        else
        {
            Console.WriteLine("This number ({0}) is appearance: {1} times!", checkNumber, count);
        }     
    }

    private static int Counter(int[] numbers, int checkNumber)
    {
        int count = 0;
        for (int index = 0; index < numbers.Length; index++)
        {
            if (numbers[index] == checkNumber)
            {
                count++;
            }
        }

        return count;
    }
}