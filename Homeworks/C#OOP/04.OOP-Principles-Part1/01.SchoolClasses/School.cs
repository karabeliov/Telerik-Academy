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

        internal void AddDisciplines(Disciplines csharp1)
        {
            throw new NotImplementedException();
        }

        internal void AddTeachers(Teachers doncho)
        {
            throw new NotImplementedException();
        }

        internal void AddClasses(Classes first)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
