using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Project
{
    public class JSONStudentsRepository : IStudentRepository
    {
        private const string _studentsFileName = "students.json";

        public List<Student> Load()
        {
            if (!File.Exists(_studentsFileName)) return StudentsFactory.GetFreshStudents();
            var json = File.ReadAllText(_studentsFileName);
            var students = JsonConvert.DeserializeObject<List<Student>>(json);
            return students;
        }

        public void Save(List<Student> students)
        {
            var json = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(_studentsFileName, json);
        }
    }
}
