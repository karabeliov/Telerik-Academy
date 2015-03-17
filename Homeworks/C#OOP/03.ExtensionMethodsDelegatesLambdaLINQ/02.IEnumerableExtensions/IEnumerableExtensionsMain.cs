namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class IEnumerableExtensionsMain
    {
        static void Main()
        {
            IEnumerable<int> list = new List<int>() { 5, 6, 7, 8, 3, 4, 6, 1 };

            int sum = list.SumOfCollection();
            int product = list.ProductOfCollection();
            int min = list.MinElement();
            int max = list.MaxElement();
            int average = list.AverageOfCollection();

            Console.WriteLine(average);
        }
    }
}
