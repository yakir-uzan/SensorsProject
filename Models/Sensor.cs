using System;
using System.Collections.Generic;

namespace SensorsProject.Models
{
    public abstract class Sensor
    {
        public string Type { get; set; }
        public bool IsActive { get; private set; } = false;
        private static int counter = 0;

        public Sensor(string type)
        {
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
