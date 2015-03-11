using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class FeaturingWithGrisko
{
    static void Main()
    {
        string input = Console.ReadLine();
        var charArray = input.ToCharArray();
        Array.Sort(charArray);
        int count = 0;
        do
        {
            if (isValidWord(charArray))
            {
                count++;
            }
            
        } while (NextPermutation(charArray));

        Console.WriteLine(count);
    }

    public static bool NextPermutation(char[] array)
    {
        for (int index = array.Length - 2; index >= 0; index--)
        {
            if (array[index] < array[index + 1])
            {
                int swapIndex = array.Length - 1;
                while (array[index] >= array[swapIndex])
                {
                    swapIndex--;
                }

                var tmp = array[index];
                array[index] = array[swapIndex];
                array[swapIndex] = tmp;

                Array.Reverse(array, index + 1, array.Length - index - 1);
                return true;
            }
        }

        return false; // no more permutation
    }

    public static bool isValidWord(char[] word)
    {
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
            {
                return false;
            }
        }

        return true;
    }
}