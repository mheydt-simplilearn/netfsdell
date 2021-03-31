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
            Console.WriteLine("Enter teacher first name:");
            // TODO: prompt, read and assign first name
            teacher.FirstName = Console.ReadLine();
        }

        // TODO add a builder method for last name (with prompt)

        protected override void BuildLastName(Teacher teacher)
        {
            Console.WriteLine("Enter teacher last name:");
            // TODO: read lastname and assign to teacher property last name
            teacher.LastName = Console.ReadLine();

        }
    }
}
