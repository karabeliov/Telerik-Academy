namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Students : Person, IComment
    {
        private string name;
        private int classNumber;

        public Students(string name, int classNumber)
        {
            this.Name = name;
            this.ClassNumber = classNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Class number cannot be negative number");
                }

                this.classNumber = value;
            }
        }

        private List<string> comment = new List<string>();
        public void AddComment(string comment)
        {
            this.comment.Add(comment);
        }

        public string PrintComment()
        {
            return string.Join(", ", comment);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(Name + " " + ClassNumber);
            return result.ToString();
        }
    }
}
