using System;
/// <summary>
/// 
/// Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
/// Print the remaining sorted array.
/// Example:
///          input	          |     result
/// 6, 1, 4, 3, 0, 3, 6, 4, 5 |	1, 3, 3, 4, 5
/// 
/// </summary>
class RemoveElementsArray
{
    static void Main()
    {
        // Input
        Console.Write("Enter Lenght of Array(N): ");
        int arrLenght = int.Parse(Console.ReadLine());

        int[] arr = new int[arrLenght];
        Console.WriteLine("Write {0} integer number to Array", arrLenght);
        for (int i = 0; i < arrLenght; i++)
        {
            Console.Write("Enter number: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        int[] store = new int[arrLenght];
        int[] sequence = store;
        int maxLength = 0;
        // Solution 
        // using binary representation to generate all possible sequence
        for (int i = 0, currentLength = 0; i < (2 << arrLenght) - 1; i++)
        {
            bool increasing = true;
            for (int j = 0, storeIndex = 0; j < arrLenght; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    // store the current sequence
                    store[storeIndex++] = arr[j];
                    // if anything is stored
                    if (storeIndex > 1)
                    {
                        if (store[storeIndex - 2] > store[storeIndex - 1])
                        {
                            increasing = false;
                        }
                    }
                    // increment the legth of the current sequence
                    currentLength++;
                }
            }
            // if new increasing sequence that is longer than the last
            if (increasing && currentLength > maxLength)
            {
                maxLength = currentLength;
                sequence = store;
                store = new int[arrLenght];
            }
            // reset
            currentLength = 0;
        }

        // Output
        Console.WriteLine();
        Console.Write("Result: ");
        for (int i = 0; i < maxLength; i++)
        {
            if (i == maxLength - 1) // remove last coma
            {
                Console.Write(sequence[i]);
            }
            else
            {
                Console.Write(sequence[i] + ", ");
            }
        }

        Console.WriteLine();
    }
}