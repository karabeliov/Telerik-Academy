﻿using System;
/// <summary>
/// 
/// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned uinteger.
/// 
/// </summary>
class BitsExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint digit3 = (number >> 3) & 1;
        uint digit4 = (number >> 4) & 1;
        uint digit5 = (number >> 5) & 1;

        uint digit24 = (number >> 24) & 1;
        uint digit25 = (number >> 25) & 1;
        uint digit26 = (number >> 26) & 1;

        // exchanges bits 24, 25 and 26
        if (digit3 == 0)
        {
            uint mask = ~(1U << 24);
            number = number & mask;
        }
        else
        {
            uint mask = 1 << 24;
            number = number | mask;
        }

        if (digit4 == 0)
        {
            uint mask = ~(1U << 25);
            number = number & mask;
        }
        else
        {
            uint mask = 1 << 25;
            number = number | mask;
        }

        if (digit5 == 0)
        {
            uint mask = ~(1U << 26);
            number = number & mask;
        }
        else
        {
            uint mask = 1 << 26;
            number = number | mask;
        }

        // exchanges bits 3, 4 and 5
        if (digit24 == 0)
        {
            uint mask = ~(1U << 3);
            number = number & mask;
        }
        else
        {
            uint mask = 1 << 3;
            number = number | mask;
        }

        if (digit25 == 0)
        {
            uint mask = ~(1U << 4);
            number = number & mask;
        }
        else
        {
            uint mask = 1 << 4;
            number = number | mask;
        }

        if (digit26 == 0)
        {
            uint mask = ~(1U << 5);
            number = number & mask;
        }
        else
        {
            uint mask = 1 << 5;
            number = number | mask;
        }

        Console.WriteLine(number);
    }
}