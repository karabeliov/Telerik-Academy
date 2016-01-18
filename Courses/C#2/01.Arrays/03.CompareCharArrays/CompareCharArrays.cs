using System;
/// <summary>
/// 
/// Write a program that compares two char arrays lexicographically (letter by letter).
/// 
/// </summary>
class CompareCharArrays
{
    static void Main()
    {
        // Input
        Console.Write("Enter Lenght of Array: ");
        int arrLenght = int.Parse(Console.ReadLine());
        char[] array1 = new char[arrLenght];
        char[] array2 = new char[arrLenght];

        Console.WriteLine("Enter {0} characters to Array 1", arrLenght);
        for (int index = 0; index < array1.Length; index++)
        {
            Console.Write("Enter character: ");
            array1[index] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter {0} characters to Array 2", arrLenght);
        for (int index = 0; index < array2.Length; index++)
        {
            Console.Write("Enter character: ");
            array2[index] = char.Parse(Console.ReadLine());
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
            else if (compare < 0)
            {
                Console.WriteLine("Array1 [ {0} ]  is Greater than Array2 [ {1} ] ", array1[index], array2[index]);
            }
            else if (compare > 0)
            {
                Console.WriteLine("Array2 [ {1} ]  is Greater than  [ {0} ] ", array1[index], array2[index]);
            }
        }

        Console.WriteLine();
    }
}