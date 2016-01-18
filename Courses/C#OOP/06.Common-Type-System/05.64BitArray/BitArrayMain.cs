namespace _05._64BitArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BitArrayMain
    {
        static void Main()
        {
            var numbers = new BitArray64(254);

            Console.WriteLine(string.Join("", numbers.BitArray));
            Console.WriteLine(numbers[26]);

            numbers.Print();

            var sampleNumber = new BitArray64(254);

            Console.WriteLine(numbers.Equals(sampleNumber));
            Console.WriteLine(numbers.Equals("11111110"));
            Console.WriteLine(numbers == sampleNumber);
        }
    }
}
