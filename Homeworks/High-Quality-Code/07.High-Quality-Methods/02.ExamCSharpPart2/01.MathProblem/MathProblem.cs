using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Linq;

public class MathProblem
{
    static int nBase = 19;
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ');
        List<int> numbersCat = new List<int>();
        List<int> sumCatNumber = new List<int>();

        int sum = 0;
        foreach (var word in words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                numbersCat.Add(word[i] - 'a');  
            }

            int decimalNumber = DecimalRepresentation(numbersCat);
            
            sum += decimalNumber;
            decimalNumber = 0;
            numbersCat.Clear();
        }

        string catNumber = CatRepresentation(sum);

        Console.WriteLine("{0} = {1}", catNumber, sum);
    }

    private static string CatRepresentation(int sum)
    {
        string catNumber = null;
        int rest;
        while (sum > 0)
        {
            rest = sum % 19;

            switch (rest)
            {
                case 0: catNumber += 'a';
                    break;
                case 1: catNumber += 'b';
                    break;
                case 2: catNumber += 'c';
                    break;
                case 3: catNumber += 'd';
                    break;
                case 4: catNumber += 'e';
                    break;
                case 5: catNumber += 'f';
                    break;
                case 6: catNumber += 'g';
                    break;
                case 7: catNumber += 'h';
                    break;
                case 8: catNumber += 'i';
                    break;
                case 9: catNumber += 'j';
                    break;
                case 10: catNumber += 'k';
                    break;
                case 11: catNumber += 'l';
                    break;
                case 12: catNumber += 'm';
                    break;
                case 13: catNumber += 'n';
                    break;
                case 14: catNumber += 'o';
                    break;
                case 15: catNumber += 'p';
                    break;
                case 16: catNumber += 'q';
                    break;
                case 17: catNumber += 'r';
                    break;
                case 18: catNumber += 's';
                    break;
                default: catNumber += rest.ToString();
                    break;
            }

            sum /= 19;
        }

        char[] array = catNumber.ToCharArray();
        Array.Reverse(array);

        return string.Join("", array);
    }

    private static int DecimalRepresentation(List<int> numbersCat)
    {
        int power = 0;
        int decimalNumber = 0;

        for (int index = numbersCat.Count - 1; index >= 0; index--)
        {
            int currentNumber = numbersCat[index];
            decimalNumber += currentNumber * Power(nBase, power);

            power++;
        }

        return decimalNumber;
    }

    private static int Power(int currentNumber, int power)
    {
        int result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= currentNumber;
        }

        return result;
    }
}
