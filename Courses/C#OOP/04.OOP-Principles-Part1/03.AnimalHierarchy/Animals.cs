namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Animals
    {
        private string name;
        private string sex;
        private int age;

        public Animals()
        {
        }

        public Animals(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            protected set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Animal must have name");
                }

                this.name = value; 
            }
        }

        public string Sex
        {
            get { return this.sex; }
            protected set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Animal must have gender");
                }

                this.sex = value; 
            }
        }

        public int Age
        {
            get { return this.age; }
            protected set 
            {
                if (value < 1)
                {
                    throw new ArgumentNullException("Age of animal cannot be negative or zero");
                }

                this.age = value; 
            }
        }
    }
}
