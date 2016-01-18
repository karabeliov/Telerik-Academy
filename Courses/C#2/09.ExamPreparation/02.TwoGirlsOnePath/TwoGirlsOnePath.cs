using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

class TwoGirlsOnePath
{
    static void Main()
    {
        ulong[] flowers = Console.ReadLine().Split(' ').Select(ulong.Parse).ToArray(); // read input and make array   this is slow!!!

        int mollyIndex = 0;
        int dollyIndex = flowers.Length - 1;

        BigInteger mollyTotalFlowers = 0;
        BigInteger dollyTotalFlowers = 0;

        string winner = string.Empty;
        while (true)
        {
            if (flowers[mollyIndex] == 0 || flowers[dollyIndex] == 0)
            {
                if (flowers[mollyIndex] == 0 && flowers[dollyIndex] == 0)
                {
                    winner = "Draw";
                }
                else if (flowers[mollyIndex] == 0)
                {
                    winner = "Dolly";
                }
                else if (flowers[dollyIndex] == 0)
                {
                    winner = "Molly";
                }

                mollyTotalFlowers += flowers[mollyIndex];
                dollyTotalFlowers += flowers[dollyIndex];

                break;
            }

            BigInteger mollyCurrentFlowers = flowers[mollyIndex]; // take flowers
            BigInteger dollyCurrentFlowers = flowers[dollyIndex];

            // TODO check if is equel
            if (mollyIndex == dollyIndex)
            {
                flowers[mollyIndex] = (ulong)(mollyCurrentFlowers % 2);
                mollyTotalFlowers += mollyCurrentFlowers / 2;
                dollyTotalFlowers += dollyCurrentFlowers / 2;
            }
            else
            {
                flowers[mollyIndex] = 0;
                flowers[dollyIndex] = 0;

                mollyTotalFlowers += mollyCurrentFlowers;
                dollyTotalFlowers += dollyCurrentFlowers;
            }

            mollyIndex = (int)((mollyIndex + mollyCurrentFlowers) % flowers.Length); // rotate array with % 
            dollyIndex = (int)((dollyIndex - dollyCurrentFlowers) % flowers.Length);

            if (dollyIndex < 0)
            {
                dollyIndex += flowers.Length;
            }
        }

        Console.WriteLine(winner);
        Console.WriteLine("{0} {1}", mollyTotalFlowers, dollyTotalFlowers);
    }
}