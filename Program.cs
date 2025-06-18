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
            FootSoldier Agent = new FootSoldier("Yakir");

            // יצירת סנסורים  
            var sensor1 = new ThermalSensor();
            var sensor2 = new PulseSensor();

            // הצמדת סנסורים לסוכן
            bool attached1 = Agent.AttachSensor(sensor1);
            bool attached2 = Agent.AttachSensor(sensor2);

            // הדפסת הסנסורים שנוספו
            Console.WriteLine("Attached sensors:");
            foreach (var sensor in Agent.AttachedSensors)
            {
                Console.WriteLine(sensor.Name);
            }
        }
    }
}
