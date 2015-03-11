using System;
using System.Linq;
/// <summary>
/// 
/// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
/// 
/// </summary>
class SortStringLength
{
    static void Main()
    {
        // Input
        Console.Write("Enter size of Array(N): ");
        int size = int.Parse(Console.ReadLine());
        string[] array = new string[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter Array[{0}] = ", i);
            array[i] = Console.ReadLine();
        }

        // Sort Array
        SortByLengthAndPrint(array);
    }

    private static void SortByLengthAndPrint(string[] array)
    {
        var sorted = from s in array
                     orderby s.Length ascending
                     select s;

        // Output
        Console.WriteLine();
        Console.WriteLine("Sort Array by string length:");
        Console.WriteLine();
        foreach (var element in sorted)
        {
            Console.WriteLine(element);
        }
    }
}