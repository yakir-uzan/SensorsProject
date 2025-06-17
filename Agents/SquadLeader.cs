using System;
using SensorsProject.Models;


namespace SensorsProject.Agents
{
    public class SquadLeader : IranianAgent
    {
        public SquadLeader(string name) : base(name, "Squad Leader", 4)
        {
        }

        public override void CounterAttack()
        {
            if (TurnCounter % 3 == 0 && AttachedSensors.Count > 0)
            {
                int indexToRemove = rnd.Next(AttachedSensors.Count);
                AttachedSensors.RemoveAt(indexToRemove);
                Console.WriteLine($"{Rank} {Name} removed 1 sensor as counterattack.");
            }
        }
    }
}
