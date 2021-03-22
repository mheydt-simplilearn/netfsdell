using System.Collections.Generic;

namespace ProjectPhase1.Strategies
{
    public interface ISortTeachersStrategy
    {
        List<Teacher> Sort(IEnumerable<Teacher> teachers);
    }
}