namespace SensorsProject
{
    internal class FootSoldier : IranianAgent
    {
        public FootSoldier(string name) : base(name)
        {
            Rank = "Foot Soldier";
            MaxSensors = 2;
            SecretSensors.Add("Thermal");
            SecretSensors.Add("Thermal");
        }

        protected override void PerformCounterAttack()
        {
            // לא עושה כלום
        }

        protected override void PerformResetIfNeeded()
        {
            // לא עושה כלום
        }
    }
}
