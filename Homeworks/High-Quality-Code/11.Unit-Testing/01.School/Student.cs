using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name 
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("Name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get { 
                return this.uniqueNumber; 
            }
            set {
                if (value < 10000 || 99999 < value )
                {
                    throw new ArgumentOutOfRangeException("Unique Number is not in valid range!");
                }

                uniqueNumber = value; 
            }
        }
        
    }
}
