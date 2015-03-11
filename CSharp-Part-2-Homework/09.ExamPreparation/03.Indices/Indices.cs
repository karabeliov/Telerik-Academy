using System;
using System.Text;

class Indices
{
    static void Main()
    {
        // Input
        int size = int.Parse(Console.ReadLine());

        string[] array = Console.ReadLine().Split(' ');
        int[] numbers = new int[size];
        bool[] visited = new bool[size];

        for (int i = 0; i < array.Length; i++)
        {
            numbers[i] = int.Parse(array[i]);
        }

        StringBuilder result = new StringBuilder(200002);
        int currentIndex = 0;
        int loopStart = -1;

        // Solution
        while (true)
        {
            if (currentIndex < 0 || currentIndex >= size)
            {
                break;
            }

            if (visited[currentIndex])
            {
                loopStart = currentIndex;

                if (loopStart >= 0)
                {
                    int index = result.ToString().IndexOf((" " + loopStart + " ").ToString());

                    if (index < 0)
                    {
                        result.Insert(0, '(');
                    }
                    else
                    {
                        result[index] = '(';
                    }

                    result[result.Length - 1] = ')';
                }

                break;
            }

            result.Append(currentIndex + " ");
            visited[currentIndex] = true;
            currentIndex = numbers[currentIndex];
        }

        // Output
        Console.WriteLine(result.ToString().Trim());
    }
}