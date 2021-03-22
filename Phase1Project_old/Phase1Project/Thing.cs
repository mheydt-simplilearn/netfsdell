using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Project
{
    public class Thing : Object
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ThingKind { get; set; }
        public string Gender { get; set; }
        public string SubSpecies { get; set; }

        public Thing(int id, string name, string thingKind, string gender, string subSpecies)
        {
            ID = id;
            Name = name;
            ThingKind = thingKind;
            Gender = gender;
            SubSpecies = subSpecies;
        }

        public Thing(string line)
        {
            var fields = line.Split('|');
            ID = int.Parse(fields[0]);
            Name = fields[1];
            ThingKind = fields[2];
            Gender = fields[3];
            SubSpecies = fields[4];

        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
