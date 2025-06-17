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
            // יצירת סוכן זוטר עם מקסימום 2 סנסורים
            FootSoldier soldier = new FootSoldier("Yakir");

            // יצירת סנסורים (יורשים של Sensor)
            var sensor1 = new ThermalSensor();
            var sensor2 = new PulseSensor();

            // ניסיון להצמיד סנסורים לסוכן
            bool attached1 = soldier.AttachSensor(sensor1);
            bool attached2 = soldier.AttachSensor(sensor2);

            Console.WriteLine($"Attach Thermal Sensor: {(attached1 ? "Success" : "Failed")}");
            Console.WriteLine($"Attach Pulse Sensor: {(attached2 ? "Success" : "Failed")}");

            // הדפסת הסנסורים שהוספו
            Console.WriteLine("Attached sensors:");
            foreach (var sensor in soldier.AttachedSensors)
            {
                Console.WriteLine(sensor.Name);
            }
        }
    }
}
