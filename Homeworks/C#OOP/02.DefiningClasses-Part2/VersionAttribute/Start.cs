namespace VersionAttribute
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Reflection;

    [Author("Kristian"), Author("I. Kenov", version = 2.0)]
    class Start
    {
        static void Main()
        {
            PrintAuthorInfo(typeof(Start));

            Console.WriteLine();
        }

        private static void PrintAuthorInfo(Type t)
        {
            Console.WriteLine("Author information for {0}", t);

            // Using reflection.
            Attribute[] attrs = Attribute.GetCustomAttributes(t);  // Reflection. 

            // Displaying output. 
            foreach (Attribute attr in attrs)
            {
                if (attr is Author)
                {
                    Author a = (Author)attr;
                    Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.version);
                }
            }
        }
    }
}
