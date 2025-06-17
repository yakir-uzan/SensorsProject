using SensorsProject.Models;

namespace SensorsProject
{
    //קלאס ליצירת סנסור סלולרי שיורש מקלאס סנסור
    class CellularSensor : Sensor
    {
        public CellularSensor(int id) : base(id, "Cellular")
        {
            Name = $"Cellular{id}";
        }
    }
}
