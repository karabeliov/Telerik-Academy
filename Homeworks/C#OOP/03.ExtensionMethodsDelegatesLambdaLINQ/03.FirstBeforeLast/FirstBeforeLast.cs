namespace FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class FirstBeforeLast
    {
        static void Main()
        {
            List<Students> allStudents = new List<Students>();
            Students kris = new Students("Kristian", "Ivanov");
            Students vili = new Students("Vili", "Ivanova");
            Students pesho = new Students("Petar", "Stoqnov");
            Students doncho = new Students("Doncho", "Minkov");

            allStudents.Add(kris);
            allStudents.Add(vili);
            allStudents.Add(pesho);
            allStudents.Add(doncho);

            var sorted = FirstNameBeforeLast(allStudents);


            foreach (var student in sorted)
            {
                Console.WriteLine(student);
            }
        }

        private static IEnumerable<Students> FirstNameBeforeLast(List<Students> collection)
        {
            var sorted = collection.OrderBy(x => x.FirstName.CompareTo(x.LastName));

            return sorted;
        }
    }
}
