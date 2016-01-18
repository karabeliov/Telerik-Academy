namespace Problem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string fn;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;
        private EmailValidator emailValidator = new EmailValidator();


        public Student(string firstName, string lastName, string fNumber, string tel, string email, List<int> allMarks, int groupN)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fNumber;
            this.Tel = tel;
            this.Email = email;
            this.Marks = allMarks;
            this.GroupNumber = groupN;
        }

        public string FirstName
        {
            get { return firstName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Form First Name cannot be empty");
                }

                firstName = value; 
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Form Last Name cannot be empty");
                }

                lastName = value; 
            }
        }

        public string FN
        {
            get { return fn; }
            private set 
            {
                if (string.IsNullOrEmpty(value) || value.Length < 7)
                {
                    throw new ArgumentNullException("Faculty number lenght must be long less 7 digits");
                }

                fn = value; 
            }
        }

        public string Tel
        {
            get { return tel; }
            private set 
            {
                if (string.IsNullOrEmpty(value) || value.Length > 13)
                {
                    throw new ArgumentNullException("Phone number lenght must be long 10 digits");
                }

                tel = value; 
            }
        }

        public string Email
        {
            get { return email; }
            private set 
            {
                if (!emailValidator.IsValidEmail(value))
                {
                    throw new ArgumentException("Invald email");
                }

                email = value; 
            }
        }

        public List<int> Marks
        {
            get { return marks; }
            private set 
            {
                if (value.Exists(x => x < 2) || value.Exists(x => x > 6))
                {
                    throw new ArgumentNullException("Ivalid marks");
                }

                marks = value; 
            }
        }

        public int GroupNumber
        {
            get { return groupNumber; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Ivalid group number");
                }

                groupNumber = value; 
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("First name: " + FirstName);
            result.AppendLine("Last name: " + LastName);
            result.AppendLine("Faculty number: " + FN);
            result.AppendLine("Tel: " + Tel);
            result.AppendLine("Email: " + Email);
            result.AppendLine("Marks: " + string.Join(", ", Marks));
            result.AppendLine("Group number: " + GroupNumber);
            return result.ToString();
        }
    }
}
