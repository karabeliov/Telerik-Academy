namespace _03.RangeExceptions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class RangeExceptions
    {
        static void Main()
        {
            int[] numbers = { 50, 200 };

            foreach (int number in numbers)
            {
                try
                {
                    if (number < 0 || number > 100)
                    {
                        throw new InvalidRangeException<int>(0, 100);
                    }

                    Console.WriteLine("{0} is in the allowed range", number);
                }
                catch (InvalidRangeException<int> ex)
                {
                    Console.WriteLine("{0} - {1}", number, ex.Message);
                }
            }
        }
    }
}
