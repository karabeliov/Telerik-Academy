using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPrintStatistics
{
    class PrintStatistics
    {
        public static void PrintAvg(double[] data)
        {
            double average = 0;
            for (int i = 0; i < data.Length; i++)
            {
                average += data[i];
            }

            average /= data.Length;

            Console.WriteLine("Average value: {0:f2}", average);
        }

        public static void PrintMin(double[] data)
        {
            double min = int.MaxValue;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < min)
                {
                    min = data[i];
                }
            }

            Console.WriteLine("Minimal value: {0}", min);
        }

        public static void PrintMax(double[] data)
        {
            double max = int.MinValue;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > max)
                {
                    max = data[i];
                }
            }

            Console.WriteLine("Maximum value: {0}", max);
        }
    }
}
