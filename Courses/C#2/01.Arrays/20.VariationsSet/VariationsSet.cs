using System;
/// <summary>
/// 
/// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
/// 
/// </summary>
class VariationsSet
{
    static void Main()
    {
        int n = 3;//int.Parse(Console.ReadLine());
        int k = 2;//int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }

        Variations(arr, new int[k], 0);
    }

    private static void Variations(int[] num, int[] arr, int index)
    {
        if (index == arr.Length)
        {
            Console.WriteLine(string.Join(", ", arr));
            return;
        }

        for (int i = 0; i < num.Length; i++)
        {
            arr[index] = num[i];
            Variations(num, arr, index + 1);
        }
    }
}