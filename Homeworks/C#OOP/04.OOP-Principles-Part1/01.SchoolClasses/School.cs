namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {
        private string name;
        private List<Disciplines> listDisciplines = new List<Disciplines>();
        private List<Teachers> listTeachers = new List<Teachers>();
        private List<Classes> listClasses = new List<Classes>(); 

        public School(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public void AddDisciplines(Disciplines choose)
        {
            listDisciplines.Add(choose);
        }

        public void AddTeachers(Teachers teacher)
        {
            listTeachers.Add(teacher);
        }

        public void AddClasses(Classes clas)
        {
            listClasses.Add(clas);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format(", ", listClasses));
            result.AppendLine(string.Format(", ", listTeachers));
            result.AppendLine(string.Format(", ", listDisciplines));
            return result.ToString();
        }
    }
}
