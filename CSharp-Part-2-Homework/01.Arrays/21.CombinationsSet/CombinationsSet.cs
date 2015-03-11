using System;
/// <summary>
/// 
/// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
/// 
/// </summary>
class CombinationsSet
{
    static void Main()
    {
        int n = 5;//int.Parse(Console.ReadLine());
        int k = 2;//int.Parse(Console.ReadLine());

        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = i + 1;
        }

        Variations(arr, new int[k], 0, 0);
    }
    private static void Variations(int[] num, int[] arr, int index, int start)
    {
        if (index == arr.Length)
        {
            Console.WriteLine(string.Join(", ", arr));
            return;
        }

        for (int i = start; i < num.Length; i++)
        {
            if (arr[index] != num[i])
            {
                arr[index] = num[i];
                start++;
            }         

            Variations(num, arr, index + 1, start);
        }
    }
}