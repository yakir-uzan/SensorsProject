using System;
using SensorsProject.Models;

namespace SensorsProject.Agents
{
    public class OrganizationLeader : IranianAgent
    {
        public OrganizationLeader(string name) : base(name, "Organization Leader", 8) { }

        //תגובות נגד של הסוכן
        public void Response()
        {
            if (roundCounter % 3 == 0)
                RemoveRndSensors(1);
        }
    }
}
