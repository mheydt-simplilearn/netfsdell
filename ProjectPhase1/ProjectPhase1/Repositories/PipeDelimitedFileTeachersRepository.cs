using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPhase1.Repositories
{
    public class PipeDelimitedFileTeachersRepository : ITeachersRepository
    {
        private string _filename;

        public PipeDelimitedFileTeachersRepository(string filename)
        {
            _filename = filename;
        }

        public IEnumerable<Teacher> Load()
        {
            var teachersAsPipeDelimited = File.ReadAllLines(_filename);
            var teachers = new List<Teacher>();
            foreach (var teacherAsPipeDelimited in teachersAsPipeDelimited)
            {
                var splits = teacherAsPipeDelimited.Split('|');
                var teacher = new Teacher(int.Parse(splits[0]), splits[1]); // TODO: add support for last name
                teachers.Add(teacher);
            }
            return teachers;
        }

        public void Save(IEnumerable<Teacher> teachers)
        {
            var teachersAsPipeDelimited = new List<string>();
            foreach (var teacher in teachers)
            {
                var teacherAsPipeDelimited = $"{teacher.ID}|{teacher.FirstName}"; // TODO: add support for last name
                teachersAsPipeDelimited.Add(teacherAsPipeDelimited);
            }
            File.WriteAllLines(_filename, teachersAsPipeDelimited);
        }
    }
}
