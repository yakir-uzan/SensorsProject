using SensorsProject.Models;

namespace SensorsProject.Sensors
{
    internal class PulseSensor : Sensor
    {
        private int activationCount = 0;
        public bool IsBroken => activationCount >= 3;

        public PulseSensor() : base("Pulse") { }

        public override void Activate()
        {
            if (!IsBroken)
            {
                base.Activate();
                activationCount++;
            }
        }
    }
}
