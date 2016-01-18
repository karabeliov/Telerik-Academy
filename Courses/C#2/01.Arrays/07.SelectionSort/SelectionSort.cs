using System;
using System.Linq;
/// <summary>
/// 
/// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
/// Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
/// 
/// </summary>
class SelectionSort
{
    static void Main()
    {
        // Input
        Console.Write("Enter Lenght of Array: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];

        Console.WriteLine("Write {0} integer number to Array", arrayLength);
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write("Enter number: ");
            array[index] = int.Parse(Console.ReadLine());
        }

        // Solution
        int i, j, min, temp;
        for (i = 0; i < array.Length - 1; i++)
        {
            min = i;
            for (j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }

            if (min != i) // swap
            {
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }           
        }

        // Output
        Console.WriteLine("Sort Array with Selection sort algorithm: {0}", string.Join(", ", array));
    }
}