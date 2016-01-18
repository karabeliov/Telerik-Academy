using System;
/// <summary>
/// 
/// 
/// 
/// </summary>
class UKFlag
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int dotsInSize = size / 2 - 1;
        for (int i = 0; i < size / 2; i++)
        {
            string dotsOut = new string('.', i);
            string bslash = "\\";
            string dotsIn = new string('.', dotsInSize);
            string slash = "/";
            dotsInSize--;
            Console.WriteLine("{0}{1}{2}|{2}{3}{0}", dotsOut, bslash, dotsIn, slash);
        }
        dotsInSize = 0;
        string line = new string('-', size / 2);
        Console.WriteLine("{0}*{0}", line);

        for (int i = size / 2 - 1; i >= 0 ; i--)
        {
            string dotsOut = new string('.', i);
            string bslash = "/";
            string dotsIn = new string('.', dotsInSize);
            string slash = "\\";
            dotsInSize++;
            Console.WriteLine("{0}{1}{2}|{2}{3}{0}", dotsOut, bslash, dotsIn, slash);
        }
    }
}