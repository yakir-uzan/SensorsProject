using SensorsProject.Models;

namespace SensorsProject.Sensors
{
    internal class MotionSensor : Sensor
    {
        private int usesLeft = 3;
        public bool IsBroken => usesLeft <= 0;

        public MotionSensor() : base("Motion") { }

        public override void Activate()
        {
            if (!IsBroken)
            {
                base.Activate();
                usesLeft--;
            }
        }
    }
}
