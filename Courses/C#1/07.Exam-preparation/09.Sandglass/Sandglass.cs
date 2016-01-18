using System;
/// <summary>
/// 
/// 
/// 
/// </summary>
class Sandglass
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());

        for (int i = 0; i < size / 2; i++)
        {
            string dots = new string('.', i);
            string stars = new string('*', size - 2 * i);
            Console.WriteLine("{0}{1}{2}", dots, stars, dots);
        }

        for (int i = size / 2; i >= 0; i--)
        {
            string dots = new string('.', i);
            string stars = new string('*', size - 2 * i);
            Console.WriteLine("{0}{1}{2}", dots, stars, dots);
        }
    }
}