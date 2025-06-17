using System;
using System.Collections.Generic;

namespace SensorsProject.Models
{
    public abstract class Sensor
    {
        public int Id { get; private set; }
        public string Type { get; set; }
        public string Name => $"{Type}{Id}";
        public bool IsActive { get; private set; } = false;
        private static int counter = 0;

        public Sensor(string type)
        {
            Id = ++counter;  
            Type = type;
        }

        // מתודה שמפעילה סנסורים
        public virtual void Activate()
        {
            IsActive = true;
        }

        //מתודה בוליאנית שבודקת אם קיים אצלו סנסור מסויים
        public bool IsMatching(IranianAgent agent)
        {
            foreach (var sensor in agent.AttachedSensors)
            {
                if (sensor.GetType() == this.GetType())
                    return true;
            }
            return false;
        }
    }
}
