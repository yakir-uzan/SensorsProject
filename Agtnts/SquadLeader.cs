namespace SensorsProject
{
    internal class SquadLeader : IranianAgent
    {
        public SquadLeader(string name) : base(name)
        {
            Rank = "Squad Leader";
            MaxSensors = 4;
            SecretSensors.AddRange(new[] { "Thermal", "Thermal", "Audio", "Audio" });
        }

        protected override void PerformCounterAttack()
        {
            if (TurnCounter % 3 == 0 && AttachedSensors.Count > 0)
            {
                int index = random.Next(AttachedSensors.Count);
                Console.WriteLine($"Counterattack! Removed sensor {AttachedSensors[index]}");
                AttachedSensors.RemoveAt(index);
            }
        }

        protected override void PerformResetIfNeeded()
        {
            // לא נדרש כאן
        }
    }
}
