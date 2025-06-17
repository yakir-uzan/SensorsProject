using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorsProject.Models;

namespace SensorsProject.Sensors
{
    //קלאס ליצירת סנסור טרמי שיורש מקלאס סנסור
    internal class ThermalSensor : Sensor
    {
        public ThermalSensor() : base("Thermal") { }
    }
}



