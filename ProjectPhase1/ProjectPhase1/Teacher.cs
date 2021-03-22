using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhase1
{
    public class Teacher
    {
        public int ID { get; set; }
        public string FirstName { get; set; }

        // TODO: Add property to last name

        public Teacher()
        {

        }

        // TODO: add parameter for last name, and asign to property
        public Teacher(int id, string firstName)
        {
            ID = id;
            FirstName = firstName;
        }

        public override string ToString()
        {
            return $"ID:{ID} FirstName:{FirstName}"; // TODO: expand for last name
        }
    }
}
