using System;
/// <summary>
/// 
/// Write a program that gets two numbers from the console and prints the greater of them.
/// Try to implement this without if statements.
/// 
/// </summary>
class NumberComparer
{
    static void Main()
    {
        Console.Write("a =  ");
        double a = int.Parse(Console.ReadLine());
        Console.Write("b =  ");
        double b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("{0} is greater", a);
        }
        else if (a < b)
        {
            Console.WriteLine("{0} is greater", b);
        }
        else
        {
            Console.WriteLine("{0} == {1}", a, b);
        }
    }
}