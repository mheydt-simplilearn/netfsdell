using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Project
{
    public class PipeDelimitedStudentsRepository : IStudentRepository
    {
        private const string _studentsFileName = "students.txt";

        public List<Student> Load()
        {
            if (!File.Exists(_studentsFileName))
                return StudentsFactory.GetFreshStudents();
            var lines = File.ReadAllLines(_studentsFileName);
            var students = new List<Student>();
            foreach (var line in lines)
            {
                var splits = line.Split('|');
                var student = new Student(splits[0], DateTime.Parse(splits[1]), splits[2], splits[3], splits[4]);
                students.Add(student);
            }
            return students;
        }

        public void Save(List<Student> students)
        {
            var studentStrings = new List<String>();
            foreach (var student in students)
            {
                var serializedStudent = $"{student.Name}|{student.DateOfBirth}|{student.Address}|{student.GuardianName}|{student.ContactNumber}";
                studentStrings.Add(serializedStudent);
            }
            File.WriteAllLines(_studentsFileName, studentStrings);
        }
    }
}
