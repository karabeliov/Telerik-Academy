namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SchoolClassesMain 
    {
        static void Main()
        {
            // Creating school
            School telerik = new School("Telerik Academy");
            

            // Creating disciplines
            Disciplines csharp1 = new Disciplines("C# part 1: ", 7, 10);
            Disciplines csharp2 = new Disciplines("C# part 2: ", 8, 10);
            Disciplines csharpOOP = new Disciplines("C# OOP: ", 6, 10);
            Disciplines csharpHQC = new Disciplines("C# High-Quality Code: ", 20, 40);
            Disciplines csharDSA = new Disciplines("C# Data Structures and Algorithms: ", 15, 25);

            telerik.AddDisciplines(csharp1);

            // Creating teachers
            Teachers doncho = new Teachers("Doncho Minkov");
            Teachers niki = new Teachers("Nikolay Kostov");

            // telerik.AddTeachers(doncho);
            // doncho.AddDisciplines(csharp1);

            List<Teachers> cSharpTeachers = new List<Teachers>() {doncho, niki}; 

            Classes first = new Classes("First Group");
            Classes second = new Classes("Second Group");

            // telerik.AddClasses(first);
            // first.AddTeachers(doncho);

            // Creating students
            Students vili = new Students("Vili", 1);
            Students kris = new Students("Kristian", 2);
            Students mitko = new Students("Dimitar", 3);
            Students gosho = new Students("Georgi", 4);

            // Add comment
            vili.AddComment("kris");
            vili.PrintComment();

            Console.WriteLine(telerik);
        }
    }
}
