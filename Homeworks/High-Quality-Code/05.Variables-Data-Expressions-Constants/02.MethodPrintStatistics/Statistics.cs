using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodPrintStatistics;

namespace MethodPrintStatistics
{
    class Statistics
    {
        static void Main()
        {
            double[] examResults = new double[] { 3, 5, 4, 6, 2, 3, 3, 3, 3 };

            PrintStatistics.PrintMin(examResults);

            PrintStatistics.PrintMax(examResults);

            PrintStatistics.PrintAvg(examResults);
        }
    }
}
