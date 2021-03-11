using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Project
{
    public interface IStudentRepository
    {
        void Save(List<Student> students);
        List<Student> Load();
    }
}
