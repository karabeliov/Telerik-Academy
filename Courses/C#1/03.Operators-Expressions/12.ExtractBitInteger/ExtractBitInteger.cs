﻿using System;
/// <summary>
/// 
/// Write an expression that extracts from given integer n the value of given bit at index p.
/// 
/// </summary>
class ExtractBitInteger
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int mask = (number >> position) & 1;

        Console.WriteLine(mask);
    }
}