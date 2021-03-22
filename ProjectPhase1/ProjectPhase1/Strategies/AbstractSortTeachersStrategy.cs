using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhase1.Strategies
{
    public abstract class AbstractSortTeachersStrategy : ISortTeachersStrategy
    {
        public abstract List<Teacher> Sort(IEnumerable<Teacher> teachers);
    }
}
