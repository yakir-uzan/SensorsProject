using System;
using SensorsProject.Models;

namespace SensorsProject.Agents 
{
    public class SeniorCommander : IranianAgent
    {
        public SeniorCommander(string name) : base(name, "Senior Commander", 6) { }

        //תגובות נגד של הסוכן
        public void Response()
        {
            if (roundCounter % 3 == 0)
            RemoveRndSensors(2);
        }
    }
}
