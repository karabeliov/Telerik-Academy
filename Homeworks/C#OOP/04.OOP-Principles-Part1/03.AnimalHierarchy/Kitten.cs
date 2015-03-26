namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Kitten : Cat
    {
        public Kitten(string name, int age, string song)
        {
            this.Name = name;
            Sex = "Female";
            this.Age = age;
            this.Song = song;
        }
    }
}
