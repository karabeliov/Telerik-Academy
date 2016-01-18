namespace _02.StudentsWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Human
    {
        private string fistName;
        private string lastName;
        public Human(string fistName, string lastName)
        {
            FistName = fistName;
            LastName = lastName;
        }

        public string FistName 
        {
            get
            {
                return this.fistName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First Name cannot be Empty!");
                }

                this.fistName = value;
            }
        }

        public string LastName 
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last Name cannot be Empty!");
                }

                this.lastName = value;
            }
        }
    }
}
