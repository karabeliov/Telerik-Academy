namespace Problem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Problem1819
    {
        public static void Main()
        {
            List<Student> allStudents = new List<Student>() 
            {
                new Student("Kristian", "Ivanov", "1306064", "+359897389543", "kris@mail.bg", new List<int>{5, 6}, 2),
                new Student("Vili", "Ivanov", "1306534", "+359873389683", "vilito@mail.bg", new List<int>{6, 6, 5, 5, 4}, 2),
                new Student("Nuri", "Georgiev", "1306535", "+359873469683", "serve@abv.bg", new List<int>{3, 2, 3, 2, 4}, 1),
                new Student("Emil", "Stoqnov", "1306536", "+359873389873", "emo@gmail.bg", new List<int>{6, 3, 3, 3, 4}, 2),
                new Student("Georgi", "Petrov", "1306532", "+35928250830", "gosho@yahoo.bg", new List<int>{6, 4, 3, 4, 4}, 1),
                new Student("Dimitar", "Borisov", "1306531", "+359886738963", "mitaka@abv.bg", new List<int>{5, 5, 5, 5, 4}, 2),
                new Student("Petar", "Atanasov", "1306533", "02761600", "p@gmail.bg", new List<int>{4, 6, 6, 4, 4}, 1),
                new Student("Denis", "Dimitrov", "1306538", "+359878356831", "deni@yahoo.bg", new List<int>{5, 5, 5, 3, 4}, 1),
            };

            // Problem 18
            var groupedStudents =
                from student in allStudents
                group student by student.GroupNumber
                    into groups
                    select new
                    {
                        Group = groups.Key,
                        Students = groups.ToList()
                    };

            foreach (var grouped in groupedStudents)
            {
                Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
                    string.Join("\r\n\r\n", grouped.Students));
            }

            // Problem 19
            var groupedStudents2 = allStudents.GroupBy(x => x.GroupNumber,
                (groupNumber, students) => new { Group = groupNumber, Students = students });

            //foreach (var grouped in groupedStudents2)
            //{
            //    Console.WriteLine("\nGroup: {0} Students:\n---------------------\n{1}", grouped.Group,
            //        string.Join("\r\n\r\n", grouped.Students));
            //}
        }
    }
}
