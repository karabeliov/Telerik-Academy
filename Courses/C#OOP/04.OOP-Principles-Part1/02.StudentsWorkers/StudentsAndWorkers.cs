namespace _02.StudentsWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StudentsAndWorkers
    {
        static void Main()
        {
            Student kris = new Student("Kristian", "Ivanov", 6);
            Worker kristian = new Worker("Kristian", "Ivanov", 100, 8, 5);

            decimal moneyPerHourse = kristian.MoneyPerHour();

            Console.WriteLine("{0} {1} have {2} in OOP.",kris.FistName, kris.LastName, kris.Grade);
            Console.WriteLine("Worker take {0:c} per hourse.", moneyPerHourse);

            // Second part of HomeWork
            List<Student> listOfStudents = new List<Student>(10)
            {
                new Student("Kristian", "Ivanov", 6),
                new Student("Vili", "Ivanova", 3),
                new Student("Viki", "Stoqnova", 5),
                new Student("Dimitar", "Toparov", 2),
                new Student("Bojidar", "Hristov", 4),
                new Student("Emil", "Kushev", 5),
                new Student("Aneliq", "Petrova", 2),
                new Student("Georgi", "Sirakov", 2),
                new Student("Boris", "Georgiev", 4),
                new Student("Stanislav", "Stanislavov", 6),
            };

            List<Worker> listOfWorkers = new List<Worker>(10)
            {
                new Worker("Kristian", "Ivanov", 100, 8, 5),
                new Worker("Vili", "Ivanova", 150, 8, 5),
                new Worker("Viki", "Stoqnova", 200, 8, 5),
                new Worker("Dimitar", "Toparov", 140, 8, 5),
                new Worker("Bojidar", "Hristov", 110, 8, 5),
                new Worker("Emil", "Kushev", 145, 8, 5),
                new Worker("Aneliq", "Petrova", 118, 8, 5),
                new Worker("Georgi", "Sirakov", 70, 4, 5),
                new Worker("Boris", "Georgiev", 100, 10, 7),
                new Worker("Stanislav", "Stanislavov", 100, 8, 7),
            };

            // Sorted
            var sortedListOfStudents = listOfStudents.OrderBy(x => x.Grade);
            var sortedListOfWorkers = listOfWorkers.OrderByDescending(x => x.MoneyPerHour());

            // Merge
            List<Human> listHumans = new List<Human>();
            listHumans.AddRange(sortedListOfStudents);
            listHumans.AddRange(sortedListOfWorkers);

            // Sorted
            var sortedListOfHumans = listHumans.OrderBy(x => x.FistName).ThenBy(x => x.LastName);

            // Print Sorted List
            Console.WriteLine();
            foreach (var human in listHumans)
            {
                Console.WriteLine(human.FistName + " " + human.LastName);
            }
        }
    }
}
