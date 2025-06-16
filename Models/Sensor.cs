using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    //קלאס כללי ליצירת סנסורים
    class Sensor
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Sensor(string type, string name)
        {
            Name = name;
            Type = type;
        }

        public void Activate()
        {

        }
    }
}
