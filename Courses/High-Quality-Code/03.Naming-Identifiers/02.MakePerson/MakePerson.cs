namespace MakePerson
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MakePerson
    {
        public enum ChooseGender { Мъж, Жена};

        static void Main()
        {
            Person pesho = new Person();
            pesho = pesho.Create(9011156532);

            Person mariq = new Person();
            mariq = mariq.Create(9711156533);

            Console.WriteLine("{0} е на {1} години и е {2} вече!", pesho.Name, pesho.Age, pesho.Gender);
            Console.WriteLine();
            Console.WriteLine("{0} е на {1} години и е {2} вече!", mariq.Name, mariq.Age, mariq.Gender);
        }
        
        public class Person
        {
            public ChooseGender Gender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public Person Create(long id)
            {
                Person newPerson = new Person();
                newPerson.Age = Math.Abs(DateTime.Now.Year - (int)(id / 100000000) % 100) % 100;
                if (id % 2 == 0)
                {
                    newPerson.Name = "Батката";
                    newPerson.Gender = ChooseGender.Мъж;
                }
                else
                {
                    newPerson.Name = "Мацето";
                    newPerson.Gender = ChooseGender.Жена;
                }

                return newPerson;
            }
        }
    }
}
