namespace _01.StudentClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : ICloneable, IComparable
    {
        public Student(string firstName, string middleName, string lastName, string SSN, string address, string mobilePhone,
                       string email, string course, Specialty speciality, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.PermanentAddress = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string SSN { get; private set; }
        public string PermanentAddress { get; private set; }
        public string MobilePhone { get; private set; }
        public string Email { get; private set; }
        public string Course { get; private set; }
        public Specialty Specialty { get; private set; }
        public University University { get; private set; }
        public Faculty Faculty { get; private set; }

        public override bool Equals(object student)
        {
            Student st = student as Student;
            if (this.SSN == st.SSN)
	        {
		        return true;
	        }

            return false;
        }
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine("Student Information");
            st.AppendLine(new string('-', 20));
            st.AppendLine("First Name: " + FirstName);
            st.AppendLine("Middle Name: " + MiddleName);
            st.AppendLine("Last Name: " + LastName);
            st.AppendLine("SSN: " + SSN);
            st.AppendLine("Permanent Address: " + PermanentAddress);
            st.AppendLine("Mobile Phone: " + MobilePhone);
            st.AppendLine("Email: " + Email);
            st.AppendLine("Course: " + Course);
            st.AppendLine("Specialty: " + Specialty);
            st.AppendLine("University: " + University);
            st.AppendLine("Faculty: " + Faculty);

            return st.ToString();
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public static bool operator ==(Student st1, Student st2)
        {
            return st1.Equals(st2);
        }

        public static bool operator !=(Student st1, Student st2)
        {
            return !(st1.Equals(st2));
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, 
                               this.SSN, this.PermanentAddress, this.MobilePhone, this.Email, 
                               this.Course, this.Specialty, this.University, this.Faculty);
        }



        public int CompareTo(object student)
        {
            var st = student as Student;
            string fullName = this.FirstName + this.MiddleName + this.LastName;
            string otherFullName = st.FirstName + st.MiddleName + st.LastName;
            int numberSSN = int.Parse(this.SSN);
            int stNumberSSN = int.Parse(st.SSN);
            if (fullName.CompareTo(otherFullName) < 0)
            {
                return -1;
            }
            if (fullName.CompareTo(otherFullName) > 0)
            {
                return 1;
            }
            if (fullName.CompareTo(otherFullName) == 0)
            {
                if (numberSSN < stNumberSSN)
                {
                    return -1;
                }
                if (numberSSN > stNumberSSN)
                {
                    return 1;
                }
                if (numberSSN == stNumberSSN)
                {
                    return 0;
                }
            }

            return 0;

        }
    }
}
