using System;
using System.Linq;
/// <summary>
/// 
/// This is from exam http://bgcoder.com/Contests/5/Telerik-Academy-Exam-1-7-Dec-2011-Morning
/// 
/// </summary>
class AstrologicalDigits
{
    static void Main()
    {
        string number = Console.ReadLine();
        string digits = string.Empty;
        int sum = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if (number[i] == '.') // Remove "."
            {
                continue;
            }
            if (number[i] == '-') // Remove "-"
            {
                continue;
            }
            else
            {
                digits += number[i];               
            }
        }
        int[] numberArray = digits.ToCharArray().Select(x => int.Parse(x + "")).ToArray(); // Add digit to Array
        sum = numberArray.Sum(); // Sum number in Array
        while (true)
        {
            if (sum < 10)
            {
                Console.WriteLine(sum);
                break;
            }
            else
            {
                number = sum.ToString();
                numberArray = number.ToCharArray().Select(x => int.Parse(x + "")).ToArray(); // add digit to Array
                sum = numberArray.Sum(); // Sum number in Array
            }
        }
    }
}