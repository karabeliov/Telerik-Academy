namespace _04.PersonClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PersonClassMain
    {
        static void Main()
        {
            Person kris = new Person("Kris");
            Person kristian = new Person("Kristian", 34);

            Console.WriteLine(kris);
            Console.WriteLine();
            Console.WriteLine(kristian);
        }
    }
}
