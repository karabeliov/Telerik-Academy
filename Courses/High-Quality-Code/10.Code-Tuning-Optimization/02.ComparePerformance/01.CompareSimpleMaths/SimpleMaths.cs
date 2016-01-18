namespace CompareSimpleMaths
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    public class SimpleMaths
    {
        static void Main()
        {
            //  result
            //  type    add | subtract | increment | multiply | divide
            //  int     003 | 003      | 006       | 003      | 006
            //  long    003 | 003      | 012       | 003      | 011
            //  float   003 | 003      | 013       | 003      | 010
            //  double  003 | 003      | 014       | 003      | 010
            //  decimal 003 | 003      | 246       | 003      | 053
            Stopwatch timer = new Stopwatch();
            int a = 50;
            int b = 10;

            for (int time = 0; time < 10; time++)
            {
                timer.Start();
                for (int i = 0; i <= 1000000; i++)
                {
                    int c = a / b;
                }

                timer.Stop();

                Console.WriteLine("RunTime " + timer.Elapsed);
                timer.Restart();
            }
        }
    }
}
