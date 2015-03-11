﻿using System;
/// <summary>
/// 
/// Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
/// in given integer number n, has value of 1.
/// 
/// </summary>
class CheckBitGivenPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        bool isOne = true;
        int mask = (number >> position) & 1;

        if (mask == 1)
        {
            Console.WriteLine(isOne);
        }
        else
        {
            Console.WriteLine(!isOne);
        }
    }
}