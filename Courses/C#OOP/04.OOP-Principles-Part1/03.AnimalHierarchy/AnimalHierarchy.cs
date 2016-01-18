namespace _03.AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class AnimalHierarchy
    {
        static void Main()
        {
            Cat presi = new Cat("Presi", "Female", 3, "Mrrr");
            Tomcat kris = new Tomcat("Kris", 2, "Miaaaauu");
            Kitten vili = new Kitten("Vili", 1, "Mrrrrr");
            Dog sharo = new Dog("Sharo", "Male", 5, "Bau Bau");
            Dog djondjo = new Dog("Djondjo", "Male", 3, "Bau Bau");
            Frog green = new Frog("Grinko", "Male", 1, "Kvak");

            Animals[] cats = new Animals[] 
            {
                presi,
                kris,
                vili,
            };

            Animals[] dogs = new Animals[] 
            {
                sharo,
                djondjo,
            };

            double averAgeCats = cats.Average(x => x.Age);
            double averAgeDogs = dogs.Average(x => x.Age);

            Console.WriteLine("Average Age in Cats is : {0}", averAgeCats);
            Console.WriteLine("Average Age in Dogs is : {0}", averAgeDogs);
        }
    }
}
