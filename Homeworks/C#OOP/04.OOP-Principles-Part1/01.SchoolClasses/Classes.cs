namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Classes : IComment
    {
        private string classes;
        private List<Teachers> listTeachers = new List<Teachers>();
        public Classes()
        {
        }

        public Classes(string classes)
            : this()
        {
            this.Class = classes;
        }

        public string Class
        {
            get
            {
                return this.classes;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 2)
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }

                this.classes = value;
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

        public void AddTeachers(Teachers teacher)
        {
            listTeachers.Add(teacher);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Join(", ", listTeachers));
            return result.ToString();
        }
    }
}
