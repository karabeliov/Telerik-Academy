using System;
namespace SolutionFrom3To5
{

    public class Students
    {
        private string firstName;
        private string lastName;
        private int age;

        public Students(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("You must write student first name");
                }

                this.firstName = value; 
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("You must write student last name");
                }

                this.lastName = value; 
            }
        }

        public int Age
        {
            get { return this.age; }
            private set 
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentException("Age must be between 0 and 150");
                }

                this.age = value; 
            }
        }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName + ", " + this.age + " years old";
        }
    }
}
