using SensorsProject.Models;

namespace SensorsProject.Sensors
{
    internal class PulseSensor : Sensor
    {
        private int activCount = 0;
        public bool IsBroken => activCount >= 3;

        public PulseSensor() : base("Pulse") { }

        public override void Activate()
        {
            if (!IsBroken)
            {
                base.Activate();
                activCount++;
            }
        }
    }
}
