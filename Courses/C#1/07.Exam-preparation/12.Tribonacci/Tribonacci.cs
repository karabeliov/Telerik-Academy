using System;
using System.Numerics;
/// <summary>
/// 
/// This is from exam http://bgcoder.com/Contests/2/Telerik-Academy-Exam-1-6-Dec-2011-Morning
/// 
/// </summary>
class Tribonacci
{
    static void Main()
    {
        BigInteger firstMember = BigInteger.Parse(Console.ReadLine());
        BigInteger secondMember = BigInteger.Parse(Console.ReadLine());
        BigInteger thirdMember = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        if (n == 1)
        {
            Console.WriteLine(firstMember);
        }
        else if (n == 2)
        {
            Console.WriteLine(secondMember);
        }
        else if (n == 3)
        {
            
        }
        else
        {
            BigInteger result = 0;
            for (int i = 3; i < n; i++)
            {
                result = firstMember + secondMember + thirdMember;
                firstMember = secondMember;
                secondMember = thirdMember;
                thirdMember = result;
            }
            Console.WriteLine(result);
        }
    }
}