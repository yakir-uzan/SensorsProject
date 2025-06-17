namespace SensorsProject
{
    internal class LightSensor : Sensor
    {
        public LightSensor() : base("Light") { }

        public string RevealInfo(IranianAgent agent)
        {
            return $"Rank: {agent.Rank}, Affiliation: {agent.Affiliation}";
        }
    }
}
