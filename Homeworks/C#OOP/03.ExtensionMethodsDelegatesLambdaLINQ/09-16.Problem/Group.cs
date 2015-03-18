namespace Problem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group(int groupN, string departmentName)
        {
            this.GroupNumber = groupN;
            this.DepartmentName = departmentName;
        }
        public int GroupNumber 
        {
            get { return groupNumber; }
            private set { groupNumber = value; }
        }

        public string DepartmentName
        {
            get { return departmentName; }
            private  set { departmentName = value; }
        }
        
    }
}
