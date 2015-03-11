using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Tubes
{
    static void Main()
    {
        // Input
        int numTubes = int.Parse(Console.ReadLine());

        int fighter = int.Parse(Console.ReadLine());
        int[] tubes = new int[numTubes];

        int maxTube = 0;
        for (int i = 0; i < numTubes; i++)
        {
            tubes[i] = int.Parse(Console.ReadLine());

            if (maxTube < tubes[i])
            {
                maxTube = tubes[i];
            }
        }

        // Solution
        int left = 1;
        int right = maxTube;
        int middle = (left + right) / 2;

        int result = 0;
        while (left <= right)
        {
            int eventual = 0;

            for (int j = 0; j < tubes.Length; j++)
            {
                eventual += tubes[j] / middle;
            }

            if (eventual < fighter)
            {
                
                right = middle - 1;
            }
            else if (eventual >= fighter)
            {
                left = middle + 1;
                result = middle;
            }

            middle = (left + right) / 2;
        }

        // Output
        Console.WriteLine(result);
    }
}