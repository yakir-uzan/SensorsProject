using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorsProject
{
    //קלאס ליצירת סנסור טרמי שיורש מקלאס סנסור
    class ThermalSensor : Sensor
    {
        public ThermalSensor() : base("termal") { }
    }
}

