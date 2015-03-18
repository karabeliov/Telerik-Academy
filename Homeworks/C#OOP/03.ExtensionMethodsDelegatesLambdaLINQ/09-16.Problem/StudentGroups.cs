namespace Problem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentGroups
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

            // var group2 = allStudents.Where(x => x.GroupNumber == 2); // with LINQ query

            var group1 = allStudents.TakeGroup(1); // extension methods
            // Print(group1);


            var stABV = allStudents.Where(st => st.Email.Contains("abv.bg")); // student user abv
            var stSofia = allStudents.Where(st => st.Tel.StartsWith("02") || st.Tel.StartsWith("+3592")); // student from Sofia student

            var stExellentMarks = allStudents.Where(st => st.Marks.Contains(6))  // anonymous
                .Select
                (st =>
                    new
                    {
                        FullName = st.FirstName + " " + st.LastName,
                        ListMarks = st.Marks
                    }
                );           
           
            //foreach (var student in stExellentMarks) // print student with Exellent marks
            //{
            //    Console.WriteLine("Full name: {0}", student.FullName);
            //    Console.WriteLine("Marks: {0}", string.Join(", ", student.ListMarks));
            //    Console.WriteLine();
            //}

            var twoMarks = allStudents.TwoMarks(); // student with 2 marks
            // Print(twoMarks);

            var studentsFrom2006 = allStudents.Where(x => x.FN[4] == '0' && x.FN[5] == '6');
            var allMarksFrom2006 = new List<int>();      

            foreach (var student in studentsFrom2006)
            {
                allMarksFrom2006.AddRange(student.Marks);
            }

            // Console.WriteLine("All marks of the students, enrolled in 2006:\n{0}", string.Join(", ", allMarksFrom2006));
        }

        private static void Print(IEnumerable<Student> group2)
        {
            foreach (var student in group2)
            {
                Console.WriteLine(student);
            }
        }
    }
}
