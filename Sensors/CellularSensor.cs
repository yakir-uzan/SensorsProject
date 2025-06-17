using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    //קלאס ליצירת סנסור סלולרי שיורש מקלאס סנסור
    class CellularSensor : Sensor
    {
        public CellularSensor(int id) : base(id, "Cellular")
        {
            Name = $"Cellular{id}";
        }
    }
}
