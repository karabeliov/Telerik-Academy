using System;
using System.Linq;
/// <summary>
/// 
/// Write a program that reads two integer arrays from the console and compares them element by element.
/// 
/// </summary>
class CompareArrays
{
    static void Main()
    {
        // Input
        Console.Write("Enter Lenght of Array: ");
        int arrLenght = int.Parse(Console.ReadLine());
        int[] array1 = new int[arrLenght];
        int[] array2 = new int[arrLenght];

        Console.WriteLine("Write {0} integer number to Array 1", arrLenght);
        for (int index = 0; index < array1.Length; index++)
        {
            Console.Write("Enter number: ");
            array1[index] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Write {0} integer number to Array 2", arrLenght);
        for (int index = 0; index < array2.Length; index++)
        {
            Console.Write("Enter number: ");
            array2[index] = int.Parse(Console.ReadLine());
        }

        // Solution and Output
        int? compare = null;
        for (int index = 0; index < array1.Length; index++)
        {
            compare = array1[index].CompareTo(array2[index]);

            Console.WriteLine();
            if (compare == 0)
            {
                Console.WriteLine("Array1 [ {0} ]  and Array2 [ {1} ]  is Equel", array1[index], array2[index]);
            }
            else if (compare == 1)
            {
                Console.WriteLine("Array1 [ {0} ]  is Greater than Array2 [ {1} ] ", array1[index], array2[index]);
            }
            else if (compare == -1)
            {
                Console.WriteLine("Array2 [ {1} ]  is Greater than  [ {0} ] ", array1[index], array2[index]);
            }
        }

        Console.WriteLine();
    }
}