namespace CompareAdvancedMaths
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AdvancedMaths
    {
        static void Main()
        {
            //  result
            //  type    square root | natural logarithm | sinus 
            //  float   009         | 030               | 055
            //  double  009         | 038               | 055
            //  decimal 
            Stopwatch timer = new Stopwatch();
            float a = 60;

            for (int time = 0; time < 10; time++)
            {
                timer.Start();
                for (int i = 0; i <= 1000000; i++)
                {
                    float c = (float)Math.Sin(a);
                }

                timer.Stop();

                Console.WriteLine("RunTime " + timer.Elapsed);
                timer.Restart();
            }
        }
    }
}
