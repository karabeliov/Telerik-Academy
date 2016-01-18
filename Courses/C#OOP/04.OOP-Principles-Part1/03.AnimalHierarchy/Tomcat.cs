namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string song)
        {
            this.Name = name;
            Sex = "Male";
            this.Age = age;
            this.Song = song;
        }
    }
}
