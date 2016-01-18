namespace DivisibleBy7And3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DivisibleBy7And3
    {
        static void Main()
        {
            int[] numbers = new int[] { 3, 4, 7, 21, 35, 42, 441, 63, 147 };

            var dividerBy7And3 = numbers.Where(x => x % 7 == 0 && x % 3 == 0);

            //var div =
            //    from num in numbers
            //    where num % 3 == 0 && num % 7 == 0
            //    select num;

            foreach (var num in dividerBy7And3)
            {
                Console.WriteLine(num);
            }
        }
    }
}
