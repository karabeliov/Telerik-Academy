using System;
/// <summary>
/// 
/// This is from exam http://bgcoder.com/Contests/5/Telerik-Academy-Exam-1-7-Dec-2011-Morning
/// 
/// </summary>
class DancingBits
{
    static void Main()
    {
        // Input 
        int K = int.Parse(Console.ReadLine());
        int N = int.Parse(Console.ReadLine());
        string concatenatedNumber = string.Empty;
        
        for (int i = 0; i < N; i++)
        {
            int numbers = int.Parse(Console.ReadLine());
            concatenatedNumber += Convert.ToString(numbers, 2);
        }

        Console.WriteLine(concatenatedNumber);
        char previousChar = concatenatedNumber[0];
        int count = 1;
        int counter = 0;       
        // Solution
        for (int i = 1; i < concatenatedNumber.Length; i++)
        {
            if (concatenatedNumber[i] == previousChar)
            {
                count++;
            }
            else
            {
                if (count == K)
                {
                    counter++;
                }
                count = 1;
                previousChar = concatenatedNumber[i];
            }
        }
        if (count == K)
        {
            counter++;
        }
        Console.WriteLine(counter);
    }
}