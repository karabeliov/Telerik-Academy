namespace _01.StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class StudentClass
    {
        static void Main()
        {
            Student kristian = new Student
                (
                    "Kristian",
                    "Georgiev",
                    "Ivanov",
                    "5456654",
                    "Sofia",
                    "0888877869",
                    "google@yahoo.com",
                    "3 course",
                    Specialty.SoftwareEngineering,
                    University.SofiaUniversity,
                    Faculty.MathematicsInformatics
                );

            Student vili = new Student
                (
                    "Vili",
                    "Georgieva",
                    "Ivanova",
                    "54566543",
                    "Sofia",
                    "08888887869",
                    "google@yahoo.com",
                    "3 course",
                    Specialty.SoftwareEngineering,
                    University.SofiaUniversity,
                    Faculty.MathematicsInformatics
                );

            Student kris = (Student)kristian.Clone(); // Clone
            // Console.WriteLine(kristian.Equals(vili));
            // Console.WriteLine(kristian == vili);

            Console.WriteLine(kris);
        }
    }
}
