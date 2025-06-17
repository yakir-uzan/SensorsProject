using System;
using System.Collections.Generic;


namespace SensorsProject.Models
{
    internal abstract class IranianAgent
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public int MaxSensors;
        public int TurnCounter = 0;

        //רשימת החולשות
        public List<string> SecretWeakness { get; private set; }
        //רשימת המוצמדים
        public List<Sensor> AttachedSensors { get; private set; }
        // רשימה כללית של כל הסנסורים
        protected static List<string> availableSensors = new List<string>  {"Thermal", "Audio", "Pulse", "Motion", "Magnetic", "Cellular", "Light", "Single"};

        public IranianAgent(string name, string rank, int maxSensors)
        {
            Name = name;
            Rank = rank;
            MaxSensors = maxSensors;
            SecretWeakness = GenerateWeaknesses();
            AttachedSensors = new List<Sensor>();
        }

        //מתודה שמוסיפה סנסורים רנדומלית לרשימת החולשות
        private List<string> GenerateWeaknesses()
        {
            Random rnd = new Random();
            List<string> Weakness = new List<string>();

            for (int i = 0; i < MaxSensors; i++)
            {
                int index = rnd.Next(availableSensors.Count);
                Weakness.Add(availableSensors[index]);
            }

            return Weakness;
        }
    }
}
