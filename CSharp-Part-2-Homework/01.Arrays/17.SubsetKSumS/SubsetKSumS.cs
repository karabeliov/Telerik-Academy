using System;
/// <summary>
/// 
/// Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
/// Find in the array a subset of K elements that have sum S or indicate about its absence.
/// 
/// </summary>
class SubsetKSumS
{
    static void Main()
    {
        // Input
        Console.Write("Enter Lenght of Array(N): ");
        int arrLenght = int.Parse(Console.ReadLine());

        int[] arr = new int[arrLenght];
        Console.WriteLine("Write {0} integer number to Array", arrLenght);
        for (int i = 0; i < arrLenght; i++)
        {
            Console.Write("Enter number: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter (K): ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Enter sum (S): ");
        int wantedSum = int.Parse(Console.ReadLine());

        // Solition and Output
        bool done = false; // use to break the loop if we find a sequence

        // generate all possible combinations
        for (int i = 0; i < (2 << arrLenght) - 1 && !done; i++)
        {
            int sum = 0;
            int count = 0;
            string temp = "";
            for (int j = 0; j < arrLenght && !done; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    sum += arr[j];
                    count++; // we count how many items were combined
                    temp += arr[j] + ",";
                }

                if (count == k && sum == wantedSum) 
                {
                    Console.WriteLine(temp.Trim(','));
                    done = true;
                }

            }

        }

        if (!done)
        {
            Console.WriteLine("Not found wanted Sum!");
        }
    }
}