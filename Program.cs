using System;
using SensorsProject.Models;
using SensorsProject.Agents;
using SensorsProject.Sensors;

namespace SensorsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // יצירת סוכן זוטר 
            FootSoldier soldier = new FootSoldier("Yakir");

            // יצירת סנסורים  
            var sensor1 = new ThermalSensor();
            var sensor2 = new PulseSensor();

            // הצמדת סנסורים לסוכן
            bool attached1 = soldier.AttachSensor(sensor1);
            bool attached2 = soldier.AttachSensor(sensor2);

            // הדפסת הסנסורים שהוספו
            Console.WriteLine("Attached sensors:");
            foreach (var sensor in soldier.AttachedSensors)
            {
                Console.WriteLine(sensor.Name);
            }
        }
    }
}
