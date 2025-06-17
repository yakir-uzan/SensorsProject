namespace SensorsProject
{
    internal class OrganizationLeader : IranianAgent
    {
        public OrganizationLeader(string name) : base(name)
        {
            Rank = "Organization Leader";
            MaxSensors = 8;
            SecretSensors.AddRange(new[] {"Thermal", "Audio", "Pulse", "Motion", "Audio", "Pulse", "Thermal", "Magnetic"});
        }

        protected override void PerformCounterAttack()
        {
            if (TurnCounter % 3 == 0 && AttachedSensors.Count > 0)
            {
                int index = random.Next(AttachedSensors.Count);
                Console.WriteLine($"Counterattack! Removed sensor: {AttachedSensors[index]}");
                AttachedSensors.RemoveAt(index);
            }
        }

        protected override void PerformResetIfNeeded()
        {
            if (TurnCounter % 10 == 0)
            {
                Console.WriteLine("!!! Full reset by Organization Leader !!!");
                AttachedSensors.Clear();
                ShuffleSecretSensors();
            }
        }

        private void ShuffleSecretSensors()
        {
            var temp = new List<string>(SecretSensors);
            SecretSensors.Clear();
            while (temp.Count > 0)
            {
                int index = random.Next(temp.Count);
                SecretSensors.Add(temp[index]);
                temp.RemoveAt(index);
            }
        }
    }
}
