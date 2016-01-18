using System;
/// <summary>
/// 
/// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
/// Print the obtained array on the console.
/// 
/// https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/01.%20Arrays/README.md link of homework
/// 
/// </summary>
class AllocateArray
{
    static void Main()
    {
        // Input
        Console.Write("Enter Lenght of Array: ");
        int arrLenght = int.Parse(Console.ReadLine());
        int[] array = new int[arrLenght];

        // Solution
        for (int index = 0; index < array.Length; index++)
        {
            array[index] = (index + 1) * 5;
        }

        // Output
        foreach (int index in array)
        {
            Console.WriteLine("{0} * 5 = {1}", index / 5, index);
        }
    }
}