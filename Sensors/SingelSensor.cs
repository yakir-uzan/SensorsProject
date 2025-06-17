using SensorsProject.Models;

namespace SensorsProject.Sensors
{
    internal class SignalSensor : Sensor
    {
        public SignalSensor() : base("Signal") { }

        public string RevealInfo(IranianAgent agent)
        {
            return $"Rank: {agent.Rank}";
        }
    }
}
