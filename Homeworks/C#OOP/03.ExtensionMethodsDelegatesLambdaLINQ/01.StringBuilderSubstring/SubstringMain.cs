namespace StringBuilderSubstring
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class SubstringMain
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Only THIS will remain after the substring.");
            Console.WriteLine(sb);
            sb = sb.Substring(5, 4);
            Console.WriteLine(sb);
        }
    }
}
