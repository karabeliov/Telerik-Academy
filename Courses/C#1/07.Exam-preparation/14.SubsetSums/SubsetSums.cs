using System;
/// <summary>
/// 
/// This is from exam http://bgcoder.com/Contests/1/CSharp-Fundamentals-2011-2012-Part-1-Sample-Exam
/// 
/// </summary>
class SubsetSums
{
    static void Main()
    {
        long sum = long.Parse(Console.ReadLine());
        byte howNumbers = byte.Parse(Console.ReadLine());
        long[] numbers = new long[howNumbers];

        for (int i = 0; i < howNumbers; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }

        int sumCounter = 0;
        int combinaton = (int)Math.Pow(2, howNumbers);
        for (int i = 1; i < combinaton; i++)
        {
             long tempSum = 0;
             for (int j = 0; j < howNumbers; j++)
             {                
                 int mask = 1 << j;
                 int iAndMask = mask & i;
                 int bit = ((1 << j) & i) >> j;

                 if (bit == 1)
                 {
                     tempSum += numbers[j];
                 }
             }

             if (tempSum == sum)
             {
                 sumCounter++;
             }
        }
        Console.WriteLine(sumCounter);
    }
}
