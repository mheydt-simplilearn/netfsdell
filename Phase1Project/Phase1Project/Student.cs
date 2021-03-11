using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Project
{
    public class Student
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string GuardianName { get; set; }

        public string ContactNumber { get; set; }

        public Student()
        {

        }

        public Student(string name, DateTime dateOfBirth, string address, string guardianName, string contactNumber)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Address = address;
            GuardianName = guardianName;
            ContactNumber = contactNumber;
        }
    }

}
