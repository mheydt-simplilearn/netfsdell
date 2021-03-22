using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhase1.Strategies
{
    public class SortTeachersByFirstNameStrategy : AbstractSortTeachersStrategy
    {
        public override List<Teacher> Sort(IEnumerable<Teacher> teachers)
        {
            var sorted = new List<Teacher>();

            foreach (var teacher in teachers)
            {
                var inserted = false;
                for (var i=0; i<sorted.Count(); i++)
                { 
                    if (string.Compare(teacher.FirstName, sorted[i].FirstName) == -1)
                    {
                        inserted = true;
                        sorted.Insert(i, teacher);
                        break;
                    }
                }

                if (!inserted) sorted.Add(teacher);
            }

            return sorted;
        }
    }
}
