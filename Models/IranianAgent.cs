using System;
using System.Collections.Generic;
using System.Linq;


namespace SensorsProject.Models
{
    public abstract class IranianAgent
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public int MaxSensors;
        public int roundCounter = 0;

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

        //להחליף את הרשימה
        //מתודה שמוסיפה סנסורים רנדומלית לרשימת החולשות
        public List<string> GenWeaknesses()
        {
            var allSensors = AgentUtils.AllSensors;
            Random rnd = new Random();
            List<string> SecretWeakness = new List<string>();

            for (int i = 0; i < MaxSensors; i++)
            {
                int rndSensors = rnd.Next(allSensors.Count);
                SecretWeakness.Add(allSensors[rndSensors]);
            }
            return SecretWeakness;
        }

        //מתודה שמצמידה סנסורים
        public bool AttachSensor(Sensor sensor)
        {
            if (AttachedSensors.Count >= MaxSensors)
                return false;

            AttachedSensors.Add(sensor);
            return true;
        }

        //מתודה שמוחקת רנדומלית סנסורים מרשימת המוצמדים
        protected void RemoveRndSensors(int amount)
        {
            Random rnd = new Random();

            for (int i = 0; i < amount ; i++)
            {
                int index = rnd.Next(AttachedSensors.Count);
                AttachedSensors.RemoveAt(index);
            }
        }

        //מתודה שמבצעת השוואה בין החולשות למוצמדים
        public string CheckSensorsMatch()
        {
            //עותק של רשימת החולשות
            List<string> copyWeakness = new List<string>(SecretWeakness);
            int matches = 0;

            foreach (Sensor sensor in AttachedSensors)
            {
                if (copyWeakness.Contains(sensor.Type))
                {
                    matches++;
                    copyWeakness.Remove(sensor.Type);
                }
            }

            return $"{matches}/{SecretWeakness.Count}";
        }

    }
}
