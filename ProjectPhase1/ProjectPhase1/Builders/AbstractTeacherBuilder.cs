using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhase1.Builders
{
    public abstract class AbstractTeacherBuilder
    {
        // abstract methods must be overridden in a derived class
        protected abstract void BuildID(Teacher teacher);
        protected abstract void BuildFirstName(Teacher teacher);
        protected abstract void BuildLastName(Teacher teacher);

        // template method
        public Teacher Build()
        {
            var teacher = new Teacher();
            BuildID(teacher);
            BuildFirstName(teacher);
            BuildLastName(teacher);
            return teacher;
        }
    }
}