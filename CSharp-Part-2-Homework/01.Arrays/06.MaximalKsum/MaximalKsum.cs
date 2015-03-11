using System;
/// <summary>
/// 
/// Write a program that reads two integer numbers N and K and an array of N elements from the console.
/// Find in the array those K elements that have maximal sum.
/// 
/// </summary>
class MaximalKsum
{
    static void Main()
    {
        // Input
        Console.Write("Enter Lenght of Array (N): ");
        int numberElement = int.Parse(Console.ReadLine());
        int[] array = new int[numberElement];

        Console.Write("Enter number that make Maximal Sum (K): ");
        int numberMakeMaxSum = int.Parse(Console.ReadLine());
        if (numberMakeMaxSum > numberElement) // Check Input
        {
            Console.WriteLine("Error K is bigger then N");
             return;
        }

        Console.WriteLine("Write {0} integer number to Array", numberElement);
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Enter number: ");
            array[index] = int.Parse(Console.ReadLine());
        }

        // Solution
        Array.Sort(array);
        int maxSum = 0;
        for (int index = array.Length - 1; index >= array.Length - numberMakeMaxSum; index--)
        {
            maxSum += array[index];

            Console.Write(array[index]); // print numbers
            if (index == array.Length - numberMakeMaxSum)
            {
                Console.Write(" = ");
            }
            else
            {
                Console.Write(" + ");
            }
        }
        
        // Output
        Console.WriteLine(maxSum);
    }
}