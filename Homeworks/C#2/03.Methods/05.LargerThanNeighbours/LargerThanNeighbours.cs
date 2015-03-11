using System;
/// <summary>
/// 
/// Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
/// 
/// </summary>
class LargerThanNeighbours
{
    static void Main()
    {
        // Input
        Console.Write("Enter Length of Array: ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[] numbers = new int[length];

        for (int index = 0; index < numbers.Length; index++)
        {
            Console.Write("Enter number in the index[{0}]: ", index);
            numbers[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter position to check: ");
        int checkPosition = int.Parse(Console.ReadLine());

        if (checkPosition > length - 1) // check position
        {
            Console.WriteLine("Invalid position");
            return;
        }

        // Solution and Output
        Neighbours(numbers, checkPosition);
    }

    private static void Neighbours(int[] numbers, int checkPosition)
    {
        int lastNeighbour = checkPosition + 1;
        int firstNeighbour = checkPosition - 1;

        // Check for end of Array
        if (numbers.Length == lastNeighbour)
        {
            lastNeighbour = 0;            
        }

        if ( 0 > firstNeighbour)
        {
            firstNeighbour = 0;
        }

        Console.WriteLine();
        if (numbers[checkPosition] >= numbers[lastNeighbour] && numbers[checkPosition] >= numbers[firstNeighbour])
        {
            Console.WriteLine("Yes");
            Console.WriteLine("The element in this index[{0}] is larger than other two neighbours!", checkPosition);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("The element in index[{0}] isn't larger than other two neighbours!", checkPosition);
        }
    }
}