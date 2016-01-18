using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorLoop
{
    public class Loop
    {
        public static void Main()
        {
            int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int expectedValue = 5;
            bool isFound = false;

            for (int index = 0; index < 10; index++)
            {
                if (numbers[index] == expectedValue)
                {
                    isFound = true;
                    break;
                }

                Console.WriteLine(numbers[index]);
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
