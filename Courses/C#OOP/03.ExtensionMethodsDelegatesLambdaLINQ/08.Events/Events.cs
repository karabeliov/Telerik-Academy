namespace Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Events
    {
        static void Main()
        {
            Publisher kris = new Publisher();

            new Subscriber("Kris", kris);
            new Subscriber("Vili", kris);

            kris.RaiseEvent(); 
        }
    }
}
