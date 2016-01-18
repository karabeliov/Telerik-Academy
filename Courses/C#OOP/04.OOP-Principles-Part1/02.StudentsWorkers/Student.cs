namespace _02.StudentsWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Human
    {
        private int grade;

        public Student(string fistName, string lastName, int grade) 
            : base(fistName, lastName)
        {
            this.Grade = grade;
        }
        public int Grade 
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException("Grade must be between 2 and 6!");
                }

                grade = value;
            }
        }
        
    }
}
