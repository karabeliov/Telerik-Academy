﻿using System;
/// <summary>
/// 
/// Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
/// 
/// </summary>
class PermutationsSet
{
    static void Main()
    {
        int n = 3;// int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }
        Permutations(arr, 0);
    }

    private static void Permutations(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            Console.WriteLine(string.Join(", ", arr));
            return;
        }

        for (int i = index; i < arr.Length; i++)
        {
            Swap(arr, i, index);
            Permutations(arr, index + 1); // recursion
            Swap(arr, i, index);
        }
    }

    private static void Swap(int[] arr, int i, int j)
    {
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}