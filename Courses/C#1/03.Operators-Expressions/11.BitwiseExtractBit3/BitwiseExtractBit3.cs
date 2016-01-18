﻿using System;
/// <summary>
/// 
/// Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
/// The bits are counted from right to left, starting from bit #0.
/// The result of the expression should be either 1 or 0.
/// 
/// </summary>
class BitwiseExtractBit3
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int mask = (number >> 3) & 1;

        Console.WriteLine(Convert.ToString(mask, 2));
    }
}