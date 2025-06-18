using System;
using SensorsProject.Models;

namespace SensorsProject.Agents
{
    public class SquadLeader : IranianAgent
    {
        public SquadLeader(string name) : base(name, "Squad Leader", 4) { }

        //תגובות נגד של הסוכן
        public void Response()
        {
            if (roundCounter % 3 == 0)
                RemoveRndSensors(1);
        }
    }
}

