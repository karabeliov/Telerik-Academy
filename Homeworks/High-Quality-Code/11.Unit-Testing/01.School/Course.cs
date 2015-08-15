using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        ICollection<Student> studentsList = new List<Student>();
        private const int MAX_STUDENT = 30;
        private string nameOfCourse;

        public Course(string nameOfCourse)
        {
            this.NameOfCourse = nameOfCourse;
        }

        public void AddStudent(Student student)
        {
            if (MAX_STUDENT < studentsList.Count)
            {
                throw new ArgumentOutOfRangeException(string.Format("Students in a {0} should be less than {1}!", nameOfCourse, MAX_STUDENT));
            }

            studentsList.Add(student);
        }

        public void AddStudents(Student[] students)
        {
            if (MAX_STUDENT < students.Count())
            {
                throw new ArgumentOutOfRangeException(string.Format("Students in a {0} should be less than {1}!", nameOfCourse, MAX_STUDENT));
            }

            for (int i = 0; i < students.Count(); i++)
            {
                studentsList.Add(students[i]);
            }
        }

        public void RemoveStudent(Student student)
        {
            if (!(studentsList.Contains(student)))
            {
                throw new IndexOutOfRangeException(string.Format("This student is no in {0} course!", NameOfCourse));
            }

            studentsList.Remove(student);
        }

        public ICollection<Student> GetStudents()
        {
            return (ICollection<Student>)studentsList.ToArray().Clone();
        }

        public string NameOfCourse 
        {
            get
            {
                return this.nameOfCourse;
            }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("Name of course cannot be empty!");
                }

                this.nameOfCourse = value;
            }
        }
    }
}
