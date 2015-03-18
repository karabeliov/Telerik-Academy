namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TimerMain
    {
        static void Main()
        {
            Timer timer = new Timer(3);
            timer.Method = PrintTimeNow;

            timer.ExecuteMethods();
        }

        private static void PrintTimeNow()
        {
            int now = DateTime.Now.Second;

            Console.WriteLine(now);
        }
    }
}
