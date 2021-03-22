using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhase1.Builders
{
    public class ConcreteTeacherBuilder : AbstractTeacherBuilder
    {
        protected override void BuildID(Teacher teacher)
        {
            Console.WriteLine("Enter an ID for the teacher");
            var idAsText = Console.ReadLine();
            teacher.ID = int.Parse(idAsText);
        }

        protected override void BuildFirstName(Teacher teacher)
        {
            // TODO: prompt, read and assign first name
        }

        // TODO add a builder method for last name (with prompt)
    }
}
