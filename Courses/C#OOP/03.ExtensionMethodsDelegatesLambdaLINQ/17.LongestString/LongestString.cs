namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class LongestString
    {
        static void Main()
        {
            string[] array = new string[]
            {
                "a",
                "aaaaa",
                "aaa",
                "aaaaa",
                "aaaa",
                "aaaaaaaaa",
                "aa",
                "aaaaaaa",
                "aaa",
                "aaaaaa",
                "aaaaa",
                "aaaaaaa",
                "aaaa",
                "aaaaa",
            };

            string maxLength = GetStringMaxL(array);

            Console.WriteLine("Max string is {0} with {1} length", maxLength, maxLength.Length);
        }

        private static string GetStringMaxL(string[] array)
        {
            string max = array.OrderByDescending(x => x.Length).First();

            return max;
        }
    }
}
