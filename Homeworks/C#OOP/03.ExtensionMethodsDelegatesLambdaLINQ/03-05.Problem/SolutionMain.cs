namespace SolutionFrom3To5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SolutionMain
    {
        public static void Main()
        {
            Students[] allStudents =
            {
                new Students("Kristian", "Ivanov", 21),
                new Students("Vili", "Ivanova", 21),
                new Students("Petar", "Stoqnov", 35),
                new Students("Doncho", "Minkov", 30),
            };

            var sorted = FirstNameBeforeLast(allStudents);

            Console.WriteLine("Sorted by first name is before its last name alphabetically");
            foreach (var student in sorted)
            {
                Console.WriteLine(student);
            }

            var youngSort = YoungStudents(allStudents, 18, 24);
            Console.WriteLine();
            Console.WriteLine("All students with age between 18 and 24");
            foreach (var student in youngSort)
            {
                Console.WriteLine(student);
            }

            var orderStudent = allStudents.OrderBy(x => x.FirstName)
                                          .ThenByDescending(x => x.LastName);

            Console.WriteLine();
            Console.WriteLine("Sort the students by first name and last name in descending order");
            foreach (var student in orderStudent)
            {
                Console.WriteLine(student);
            }
        }

        private static IEnumerable<Students> YoungStudents(Students[] collection, int startAge, int endAge)
        {
            var sorted = collection.Where(st => st.Age >= startAge && st.Age <= endAge);

            return sorted;
        }

        private static IEnumerable<Students> FirstNameBeforeLast(Students[] collection)
        {
            var sorted = collection.OrderBy(x => x.FirstName.CompareTo(x.LastName) < 0);

            return sorted;
        }
    }
}