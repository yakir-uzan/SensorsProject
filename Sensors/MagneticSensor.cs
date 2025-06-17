namespace SensorsProject
{
    internal class MagneticSensor : Sensor
    {
        private int remainingBlocks = 2;

        public MagneticSensor() : base("Magnetic") { }

        public bool BlockCounterAttack()
        {
            if (remainingBlocks > 0)
            {
                remainingBlocks--;
                return true;
            }
            return false;
        }
    }
}
