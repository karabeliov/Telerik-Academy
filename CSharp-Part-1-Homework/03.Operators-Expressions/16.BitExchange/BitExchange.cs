using System;
/// <summary>
/// 
/// Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned uinteger.
/// The first and the second sequence of bits may not overlap.
/// 
/// 1140867093  // 01000100 00000000 01000000 00010101
/// 1107312677  // 01000010 00000000 01000000 00100101
/// </summary>
class BitExchange
{
    static void Main()
    {
        Console.Write("Enter number: ");
        long number = long.Parse(Console.ReadLine());
        Console.Write("Enter P position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter Q position: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation of {0} is: {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));

        if (p + k - 1 > 31 || q + k - 1 > 31)
        {
            Console.WriteLine("Out of range");
            return;
        }
        else if (q < p + k - 1 && p < q + 1)
        {
            Console.WriteLine("Overlapping");
            return;
        }
        else
        {
            for (int i = p; i <= p + k - 1; i++)
            {
                long mask = 1; 
                long bitQ = (number & (mask << q)) >> q;
                long bitP = (number & (mask << i)) >> i;
                number = number & ~(mask << i); //nullify
                number = number & ~(mask << q); //nullify
                number = number | (bitQ << i); //change bit p
                number = number | (bitP << q); //change bit q            
                q++;
            }  
        }
        Console.WriteLine("Binary representation of {0} is: {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}