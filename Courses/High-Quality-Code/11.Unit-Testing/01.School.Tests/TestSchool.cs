using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Tests
{
    [TestClass]
    public class TestStudents
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentHasInvalidName()
        {
            string name = "";
            int uniqueNumber = 1000;
            var student = new Student(name, uniqueNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentUniqueNumberIsIncorrect()
        {
            string name = "Pesho";
            int uniqueNumber = 1000;
            var student = new Student(name, uniqueNumber);
        }
    }

    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CourseHasIncorrectName()
        {
            string name = "";
            var course = new Course(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CourseHasInvalidCountOfStudents()
        {
            Student[] students = new Student[32];
            string nameOfCourse = "JavaScript";
            Course javaScript = new Course(nameOfCourse);

            javaScript.AddStudents(students);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void StudentIsNotContainInCourse()
        {
            string name = "Pesho";
            int uniqueNumber = 10000;
            var pesho = new Student(name, uniqueNumber);

            string nameOfCourse = "JavaScript";
            Course javaScript = new Course(nameOfCourse);

            javaScript.AddStudent(pesho);
            javaScript.RemoveStudent(pesho);
            javaScript.RemoveStudent(pesho);
        }
    }
}
