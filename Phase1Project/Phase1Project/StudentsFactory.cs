using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Project
{
    public abstract class StudentsFactory
    {
        public static List<Student> GetFreshStudents()
        {
            return new List<Student>()
            {
                new Student("Mike", DateTime.Now, "My street", "none", "555-1212"),
                new Student("Dan", DateTime.Now.AddYears(-1), "Another street", "their mom", "555-2222")
            };
        }
    }
}
