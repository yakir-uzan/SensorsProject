using System;
using System.Collections.Generic;


namespace SensorsProject.Models
{
    public abstract class IranianAgent
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public int MaxSensors;
        public int TurnCounter = 0;

        //רשימת החולשות
        public List<string> SecretWeakness { get; private set; }
        //רשימת המוצמדים
        public List<Sensor> AttachedSensors { get; private set; }
        
        public IranianAgent(string name, string rank, int maxSensors)
        {
            Name = name;
            Rank = rank;
            MaxSensors = maxSensors;
            SecretWeakness = GenWeaknesses();
            AttachedSensors = new List<Sensor>();
        }

        //מתודה שמוסיפה סנסורים רנדומלית לרשימת החולשות
        private List<string> GenWeaknesses()
        {
            var allSensors = AgentUtils.AllSensors;
            Random rnd = new Random();
            List<string> Weakness = new List<string>();

            for (int i = 0; i < MaxSensors; i++)
            {
                int rndSensors = rnd.Next(allSensors.Count);
                Weakness.Add(allSensors[rndSensors]);
            }
            return Weakness;
        }

        //מתודה שמצמידה סנסורים
        public bool AttachSensor(Sensor sensor)
        {
            if (AttachedSensors.Count >= MaxSensors)
                return false; 

            AttachedSensors.Add(sensor);
            return true;
        }
    }
}
