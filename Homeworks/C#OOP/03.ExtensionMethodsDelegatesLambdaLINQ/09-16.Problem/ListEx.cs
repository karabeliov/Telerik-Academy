namespace Problem
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public static class ListEx
    {
        public static List<Student> TakeGroup(this List<Student> list, int groupNumber)
        {
            var listGroup = list.Where(x => x.GroupNumber == groupNumber);
            return listGroup.ToList<Student>();
        }

        public static List<Student> TwoMarks(this List<Student> list)
        {
            var listGroup = list.Where(x => x.Marks.Count() == 2);
            return listGroup.ToList<Student>();
        }
    }
}
