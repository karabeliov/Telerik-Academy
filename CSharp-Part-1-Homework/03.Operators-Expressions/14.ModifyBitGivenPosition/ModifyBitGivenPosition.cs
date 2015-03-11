﻿using System;
/// <summary>
/// 
/// We are given an integer number n, a bit value v (v=0 or 1) and a position p.
/// Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p
/// from the binary representation of n while preserving all other bits in n.
/// 
/// </summary>
class ModifyBitGivenPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int value = int.Parse(Console.ReadLine());

        if (value == 0)
        {
            int mask = ~(1 << position);
            number = number & mask;
        }
        else
        {
            int mask = 1 << position;
            number = number | mask;
        }

        Console.WriteLine(number);
    }
}