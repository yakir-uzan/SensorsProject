using System;
using SensorsProject.Models;

namespace SensorsProject.Agents
{
    public class SquadLeader : IranianAgent
    {
        public SquadLeader(string name) : base(name, "Squad Leader", 4) { }
    }
}
