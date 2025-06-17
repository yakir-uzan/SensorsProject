using SensorsProject.Models;

namespace SensorsProject.Sensors
{
    // סנסור אודיו בלי יכולות מיוחדות
    internal class AudioSensor : Sensor
    {
        public AudioSensor() : base("Audio") { }
    }
}
