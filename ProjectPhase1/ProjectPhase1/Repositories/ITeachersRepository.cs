using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhase1.Repositories
{
    public interface ITeachersRepository
    {
        void Save(IEnumerable<Teacher> teachers);
        IEnumerable<Teacher> Load();
    }
}
