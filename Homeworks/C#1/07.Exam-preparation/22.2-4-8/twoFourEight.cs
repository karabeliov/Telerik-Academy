using System;
using System.Numerics;
class twoFourEight
{
    static void Main()
    {
        checked
        {
            long A = long.Parse(Console.ReadLine());
            long secretCode = long.Parse(Console.ReadLine());
            long C = long.Parse(Console.ReadLine());
            BigInteger result = 0;

            if (secretCode == 2)
            {
                result = A % C;
            }
            else if (secretCode == 4)
            {
                result = A + C;
            }
            else if (secretCode == 8)
            {
                result = A * C;
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            if (result % 4 == 0)
            {
                BigInteger resultR = result / 4;
                Console.WriteLine(resultR);
            }
            else if (result % 4 != 0)
            {
                BigInteger resultR = result % 4;
                Console.WriteLine(resultR);
            }

        Console.WriteLine(result);

        }
    }
}