namespace SensorsProject
{
    internal class SeniorCommander : IranianAgent
    {
        public SeniorCommander(string name) : base(name)
        {
            Rank = "Senior Commander";
            MaxSensors = 6;
            SecretSensors.AddRange(new[] { "Thermal", "Audio", "Pulse", "Pulse", "Thermal", "Audio"});
        }

        protected override void PerformCounterAttack()
        {
            if (TurnCounter % 3 == 0)
            {
                for (int i = 0; i < 2 && AttachedSensors.Count > 0; i++)
                {
                    int index = random.Next(AttachedSensors.Count);
                    Console.WriteLine($"Counterattack! Removed sensor: {AttachedSensors[index]}");
                    AttachedSensors.RemoveAt(index);
                }
            }
        }

        protected override void PerformResetIfNeeded()
        {
            // אין איפוס
        }
    }
}
