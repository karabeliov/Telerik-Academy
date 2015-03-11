using System;
/// <summary>
/// 
/// This is from exam http://bgcoder.com/Contests/42/Telerik-Academy-Exam-1-28-Dec-2012
/// 
/// </summary>
class ANacci
{
    static void Main()
    {
        const int shift = 64;
        string firstMember = Console.ReadLine();
        int first = firstMember[0] - shift;
        string secondMember = Console.ReadLine();
        int second = secondMember[0] - shift;
        int rowsNumber = int.Parse(Console.ReadLine());
        int next = first + second;

        Console.WriteLine(Convert.ToChar(first + shift));
        Console.WriteLine("{0}{1}",Convert.ToChar(second + shift), Convert.ToChar(next + shift));
        first = second;
        second = next;
        for (int i = 3; i <= rowsNumber; i++)
        {
            next = first + second;
            Console.Write(Convert.ToChar(next + shift));
            Console.Write(new string(' ', i - 2));
            Console.WriteLine(Convert.ToChar((second + next) + shift));
            first = second;
            second = next;
        }
    }
}