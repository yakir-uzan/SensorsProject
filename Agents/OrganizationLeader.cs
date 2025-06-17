using System;
using SensorsProject.Models;

namespace SensorsProject.Agents
{
    public class OrganizationLeader : IranianAgent
    {
        public OrganizationLeader(string name) : base(name, "Organization Leader", 8) { }

        public override void CounterAttack()
        {
            if (TurnCounter % 3 == 0 && AttachedSensors.Count > 0)
            {
                AttachedSensors.RemoveAt(rnd.Next(AttachedSensors.Count));
                Console.WriteLine($"{Rank} {Name} removed 1 sensor as counterattack.");
            }

            if (TurnCounter % 10 == 0)
            {
                SecretWeaknesses = GenerateSecretWeaknesses();
                AttachedSensors.Clear();
                Console.WriteLine($"{Rank} {Name} reset weaknesses and removed all sensors on turn {TurnCounter}.");
            }
        }

        private List<string> GenSecretWeaknesses()
        {
            // זהה את המתודה הפרטית ממחלקת האב, 
            // מאחר ולא נגיש אליה יש להעתיק או לשנות את המבנה לשימוש חוזר
            string[] possibleWeaknesses = { "Thermal", "Audio", "Pulse", "Motion", "Magnetic", "Cellular", "Light" };
            var weaknesses = new List<string>();
            Random rndLocal = new Random();
            for (int i = 0; i < MaxSensors; i++)
            {
                int index = rndLocal.Next(possibleWeaknesses.Length);
                weaknesses.Add(possibleWeaknesses[index]);
            }
            return weaknesses;
        }
    }
}
