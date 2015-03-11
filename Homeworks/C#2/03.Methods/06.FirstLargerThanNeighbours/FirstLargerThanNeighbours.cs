using System;
/// <summary>
/// 
/// Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
/// 
/// </summary>
class FirstLargerThanNeighbours
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

        // Solution and Output
        int checkPosition = 0;
        Console.WriteLine();
        for (int i = 0; i < numbers.Length; i++)
        {
            checkPosition = i;
            bool isExist = Neighbours(numbers, checkPosition) > -1;

            if (isExist)
            {
                Console.WriteLine("index[{0}]", Neighbours(numbers, checkPosition));
                Console.WriteLine();
                Console.WriteLine("First element in array that is larger than its neighbours is in the index[{0}]", Neighbours(numbers, checkPosition));
                break;
            }
            else if (!isExist && i == numbers.Length - 1)
            {
                Console.WriteLine("index[{0}]", Neighbours(numbers, checkPosition));
                Console.WriteLine();
                Console.WriteLine("There’s no such element!", Neighbours(numbers, checkPosition));
            }
        }
    }

    private static int Neighbours(int[] numbers, int checkPosition)
    {
        int lastNeighbour = checkPosition + 1;
        int firstNeighbour = checkPosition - 1;

        // Check for end of Array
        if (numbers.Length == lastNeighbour)
        {
            lastNeighbour = 0;
        }

        if (0 > firstNeighbour)
        {
            firstNeighbour = 0;
        }

        if (numbers[checkPosition] > numbers[lastNeighbour] && numbers[checkPosition] > numbers[firstNeighbour])
        {
            return checkPosition;
        }
        else
        {
            return -1;
        }
    }
}