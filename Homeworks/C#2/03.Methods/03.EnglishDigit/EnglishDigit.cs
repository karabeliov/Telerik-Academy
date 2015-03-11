using System;
/// <summary>
/// 
/// Write a method that returns the last digit of given integer as an English word.
/// 
/// </summary>
class EnglishDigit
{
    static void Main()
    {
        // Input
        Console.Write("Enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        // Solution
        string word = LastDigitAsWord(number);

        // Output
        Console.WriteLine("Last digit as word:  {0}", word);
    }

    private static string LastDigitAsWord(int number)
    {
        int digit = number % 10;
        string lastDigitAsWord = string.Empty;
        switch (digit)
        {
            case 0: lastDigitAsWord = "zero";
                break;
            case 1: lastDigitAsWord = "one";
                break;
            case 2: lastDigitAsWord = "two";
                break;
            case 3: lastDigitAsWord = "three";
                break;
            case 4: lastDigitAsWord = "four";
                break;
            case 5: lastDigitAsWord = "five";
                break;
            case 6: lastDigitAsWord = "six";
                break;
            case 7: lastDigitAsWord = "seven";
                break;
            case 8: lastDigitAsWord = "eight";
                break;
            case 9: lastDigitAsWord = "nine";
                break;
        }

        return lastDigitAsWord;
    }
}