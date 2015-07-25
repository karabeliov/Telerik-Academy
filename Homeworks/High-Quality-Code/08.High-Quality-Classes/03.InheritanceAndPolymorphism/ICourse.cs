using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    public interface ICourse
    {
        string Name { get; set; }
        string TeacherName { get; set; }
        IList<string> Students { get; set; }
    }
}
