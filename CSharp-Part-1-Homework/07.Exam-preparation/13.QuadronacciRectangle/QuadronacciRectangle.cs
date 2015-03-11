using System;
/// <summary>
/// 
/// This is from exam http://bgcoder.com/Contests/43/Telerik-Academy-Exam-1-29-Dec-2012
/// 
/// </summary>
class QuadronacciRectangle
{
    static void Main()
    {
        long one = long.Parse(Console.ReadLine());
        long two = long.Parse(Console.ReadLine());
        long three = long.Parse(Console.ReadLine());
        long four = long.Parse(Console.ReadLine());
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        if (cols == 4)
        {
            Console.WriteLine(one + " " + two + " " + three + " " + four);
        }
        else
        {
            Console.Write(one + " " + two + " " + three + " " + four + " ");
        }
        long result = 0;
        for (int row = 0; row < rows; row++)
        {
            int currentCol = 0;
            if (row == 0)
            {
                currentCol = 4;
            }
            for (int col = currentCol; col < cols; col++)
            {
                result = one + two + three + four;

                one = two;
                two = three;
                three = four;
                four = result;
                if (col + 1 == cols)
                {
                    Console.WriteLine(result);
                }
                else
                {

                    Console.Write(result + " ");
                }
            }
        }
    }
}