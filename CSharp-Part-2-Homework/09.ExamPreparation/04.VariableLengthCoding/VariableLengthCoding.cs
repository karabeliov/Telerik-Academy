using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class VariableLengthCoding
{
    static void Main()
    {
        // Input
        string line = Console.ReadLine();
        string[] num = line.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

        List<int> numbers = new List<int>();

        foreach (var number in num)
        {
            numbers.Add(int.Parse(number));
        }

        StringBuilder binNum = new StringBuilder();
        foreach (var number in numbers)
        {
            binNum.Append(Convert.ToString(number, 2).PadLeft(8, '0'));
        }

        int numDiction = int.Parse(Console.ReadLine());
        char[] dictionary = new char[numDiction + 1];
        for (int i = 0; i < numDiction; i++)
        {
            string word = Console.ReadLine();
            char symbol = word[0];
            int index = int.Parse(word.Substring(1));

            dictionary[index] = symbol;
        }

        // Solution
        int count = 0;
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < binNum.Length; i++)
        {
            if (binNum[i] == '1')
            {
                count++;
            }
            else //if (binNum[i] == '0')
            {
                result.Append(dictionary[count]);
                count = 0;
            }
        }

        if (count > 0) // this is not necessary
        {
            result.Append(dictionary[count]);
        }

        // Output
        Console.WriteLine(result);
    }
}