using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// 
/// Write a program that calculates the value of given arithmetical expression.
/// The expression can contain the following elements only:
///  - Real numbers, e.g. 5, 18.33, 3.14159, 12.6
///  - Arithmetic operators: +, -, *, / (standard priorities)
///  - Mathematical functions: ln(x), sqrt(x), pow(x,y)
///  - Brackets (for changing the default priorities): (, )
/// 
/// </summary>
class ArithmeticalExpressions
{
    static void Main()
    {
        // Input
        Console.WriteLine("Enter the expression: ");
        string input = Console.ReadLine().Trim();
        string trimmedInput = input.Replace(" ", string.Empty);

        // Solution
        var separetedTokens = SeparateTokens.Tokens((trimmedInput));
        var reverse = ConvertToReversePolishNotation.ConvertToReverse(separetedTokens);
        var result = FinalResultFromRPN.FinalResult(reverse);

        // Output
        Console.WriteLine("\nThe result is:   ~ {0:F2}", result);
    }
}