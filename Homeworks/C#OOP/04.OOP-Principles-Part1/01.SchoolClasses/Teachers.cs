namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Teachers : Person, IComment
    {
        private string name;
        private List<Disciplines> listDisciplines = new List<Disciplines>();
        public Teachers(string name)
        {
            this.Name = name;
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

        private List<string> comment = new List<string>();
        public void AddComment(string comment)
        {
            this.comment.Add(comment);
        }

        public string PrintComment()
        {
            return string.Join(", ", comment);
        }

        public void AddDisciplines(Disciplines choose)
        {
            listDisciplines.Add(choose);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format(", ", listDisciplines));
            return result.ToString();
        }
    }
}
