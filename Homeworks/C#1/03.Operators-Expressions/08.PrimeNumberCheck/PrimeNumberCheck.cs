using System;
/// <summary>
/// 
/// Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
/// 
/// </summary>
class PrimeNumberCheck
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        bool isPrime = false;

        if (number == 1)
	    {
            isPrime = false;
	    }
        else if (number == 2)
	    {
            isPrime = true;
	    }
        else
	    {
            for (int i = 2; i < number; i+=2)
			{
                if (number % i == 0)
	            {
                     Console.WriteLine(isPrime);
                     return;
	            }
                else
                {
                    isPrime = true;
                }
			}
	    }
        Console.WriteLine(isPrime);
    }
}