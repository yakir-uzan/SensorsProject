using System;

namespace SensorsProject.Agents
{
    public class SeniorCommander : IranianAgent
    {
        public SeniorCommander(string name) : base(name, "Senior Commander", 6)
        {
        }

        public override void CounterAttack()
        {
            if (TurnCounter % 3 == 0 && AttachedSensors.Count > 0)
            {
                int removeCount = Math.Min(2, AttachedSensors.Count);
                for (int i = 0; i < removeCount; i++)
                {
                    int indexToRemove = rnd.Next(AttachedSensors.Count);
                    AttachedSensors.RemoveAt(indexToRemove);
                }
                Console.WriteLine($"{Rank} {Name} removed {removeCount} sensors as counterattack.");
            }
        }
    }
}
