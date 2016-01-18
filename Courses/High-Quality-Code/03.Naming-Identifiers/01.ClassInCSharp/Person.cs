namespace ClassInCSharp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Person
    {
        const int MaxCount = 6;

        public static void Main()
        {
            Person.Student pesho = new Person.Student();

            pesho.WriteInConsole(true);
        }

        public class Student
        {
            public void WriteInConsole(bool isWrite)
            {
                string answer = isWrite.ToString();
                Console.WriteLine(answer);
            }
        }
    }
}
